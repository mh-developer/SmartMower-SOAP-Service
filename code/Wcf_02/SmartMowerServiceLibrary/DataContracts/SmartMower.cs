using System;
using System.Data;
using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class SmartMower
    {
        public SmartMower(string name, string producer, string serial, double cuttingLevel, int noiseLevel)
        {
            Name = name;
            Producer = producer;
            Serial = serial;
            CuttingLevel = cuttingLevel;
            NoiseLevel = noiseLevel;
        }

        [DataMember] public string Name { get; set; }
        [DataMember] public string Producer { get; set; }
        [DataMember] public bool Power { get; set; } = true;
        [DataMember] public string Serial { get; set; }
        [DataMember] public int BatteryLevel { get; set; } = 100;
        [DataMember] public bool BatteryAutoCharge { get; set; } = true;
        [DataMember] public bool IsCharging { get; set; } = false;
        [DataMember] public double CuttingLevel { get; set; }
        [DataMember] public int NoiseLevel { get; set; }
        [DataMember] public bool IsMoving { get; set; } = false;

        [DataMember(Name = "MotionSensor")]
        public MotionSensor MotionSensor
        {
            get
            {
                var motion = new MotionSensor();
                motion.Name = "Premikanje";
                Random r = new Random();
                motion.IsObstacleOnFront = r.Next(0, 100) >= 40;
                motion.Value = motion.IsObstacleOnFront ? "Ovira je na poti." : "Pot je prosta.";
                return motion;
            }
            set => throw new InvalidOperationException();
        }

        [DataMember(Name = "LightSensor")]
        public LightSensor LightSensor
        {
            get
            {
                var light = new LightSensor();
                light.Name = "Svetloba";
                Random r = new Random();
                light.IsLight = r.Next(0, 100) >= 25;
                light.Value = light.IsLight ? "Dan" : "Noč";
                return light;
            }
            set => throw new InvalidOperationException();
        }

        [DataMember(Name = "RainSensor")]
        public RainSensor RainSensor
        {
            get
            {
                var rain = new RainSensor();
                rain.Name = "Dež";
                Random r = new Random();
                rain.IsRain = r.Next(0, 100) >= 75;
                rain.Value = rain.IsRain ? "Dežuje" : "Sončno";
                return rain;
            }
            set => throw new InvalidOperationException();
        }

        [DataMember(Name = "TemperatureSensor")]
        public TemperatureSensor TemperatureSensor
        {
            get
            {
                var temp = new TemperatureSensor();
                temp.Name = "Temperatura";
                Random r = new Random();
                temp.Temperature = r.Next(-5, 36);
                temp.Value = $"Temperatura: {temp.Temperature} stopinj celzija";
                return temp;
            }
            set => throw new InvalidOperationException();
        }
    }
}