using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using Wcf_Odjemalec.SmartMowerServiceReference;

namespace Wcf_Odjemalec
{
    public class Program
    {
        private static readonly SmartMower1Client _smartMower1Client = new SmartMower1Client();

        public static async Task Main(string[] args)
        {
            try
            {
                _smartMower1Client.Open();

                var mower = await _smartMower1Client.GetStateAsync();
                Console.WriteLine("Kosilnica: {0}, {1}, {2}", mower.Name, mower.Producer, mower.Serial);

                while (true)
                {
                    await HandleConsoleActions();
                }
            }
            catch (TimeoutException t)
            {
                Console.WriteLine("Zgodila se je prekoračitev maksimalnega časa čakanja: {0}", t.Message);
                _smartMower1Client.Abort();
            }
            catch (FaultException<InvalidData> fesh)
            {
                Console.WriteLine("Zgodila se je nepričakovana operacija: {0}", fesh.Reason);
                _smartMower1Client.Abort();
            }
            catch (FaultException fe)
            {
                Console.WriteLine("Zgodila se je nepričakovana operacija: {0}", fe.Reason);
                _smartMower1Client.Abort();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Imamo težave s komunikacijo: {0}", ce.StackTrace);
                _smartMower1Client.Abort();
            }

            Console.ReadLine();
        }

        private static async Task HandleConsoleActions()
        {
            Console.WriteLine("-----------------------------------------");
            Console.Write("Press one (1) to get mower running status,\n" +
                          "press two (2) for turn on/off mower,\n" +
                          "press three (3) for lower cutting level,\n" +
                          "press four (4) for raise cutting level,\n" +
                          "press five (5) for switch auto charging,\n" +
                          "press six (6) for test fault error,\n" +
                          "press seven (7) for exit: ");
            var key = Console.ReadKey();
            Console.WriteLine("\n-----------------------------------------");
            switch (key.KeyChar)
            {
                case '1':
                    await GetMowerStatus(_smartMower1Client);
                    break;
                case '2':
                    await SetMowerPower(_smartMower1Client);
                    break;
                case '3':
                    await MowerLowerCutting(_smartMower1Client);
                    break;
                case '4':
                    await MowerRaiseCutting(_smartMower1Client);
                    break;
                case '5':
                    await SetMowerBatteryAutoCharge(_smartMower1Client);
                    break;
                case '6':
                    await FaultError(_smartMower1Client);
                    break;
                case '7':
                    _smartMower1Client.Close();
                    Environment.Exit(0);
                    break;
                default:
                    await HandleConsoleActions();
                    break;
            }
        }

        private static async Task GetMowerStatus(SmartMower1Client client)
        {
            var results = new List<Task<ResponseMessage>>();

            for (int i = 0; i < 30; i++)
            {
                Console.Write(".");
                var result = client.GetMowerRunningStatusAsync();
                results.Add(result);
                Thread.Sleep(200);
            }

            var response = await Task.WhenAll(results);
            Console.WriteLine();

            foreach (var message in response)
            {
                Console.WriteLine($"REZULTATI: {message.Message}");
            }
        }

        private static async Task SetMowerPower(SmartMower1Client client)
        {
            await client.SetPowerOnOffAsync();
            var state = await client.GetStateAsync();
            Console.WriteLine("Kosilnica je {0}.", state.Power ? "vključena" : "izključena");
        }

        private static async Task MowerLowerCutting(SmartMower1Client client)
        {
            await client.LowerCuttingLevelAsync();
            var state = await client.GetStateAsync();
            Console.WriteLine("Višina košnje je {0}.", state.CuttingLevel);
        }

        private static async Task MowerRaiseCutting(SmartMower1Client client)
        {
            await client.RaiseCuttingLevelAsync();
            var state = await client.GetStateAsync();
            Console.WriteLine("Višina košnje je {0}.", state.CuttingLevel);
        }

        private static async Task SetMowerBatteryAutoCharge(SmartMower1Client client)
        {
            await client.SetBatteryAutoChargeOnOffAsync();
            var state = await client.GetStateAsync();
            Console.WriteLine("Avtomatsko polnjenje je  {0}.", state.BatteryAutoCharge ? "vključeno" : "izključeno");
        }

        private static async Task FaultError(SmartMower1Client client)
        {
            await client.SendErrorAsync("To je zelo huda napaka.");
        }
    }
}