using SmartMowerServiceLibrary.DataContracts;
using System;
using System.ServiceModel;

namespace SmartMowerServiceLibrary
{
    public class SmartMowerService : ISmartMowerService
    {
        private SmartMower _kosilnica = new SmartMower("AUTOMOWER 435X AWD", "HUSQVARNA", "SN2151257291813", 3.0, 62);


        public SmartMower GetState()
        {
            return _kosilnica;
        }

        public ResponseMessage GetMowerRunningStatus()
        {
            if (!_kosilnica.Power)
            {
                throw new FaultException("Kosilnica ne deluje.");
            }

            _kosilnica.BatteryLevel = new Random().Next(0, 100);
            if (_kosilnica.IsCharging)
            {
                if (!(_kosilnica.BatteryLevel > 90))
                {
                    _kosilnica.IsMoving = false;
                    return new ResponseMessage(true, "Kosilnica se trenutno polni.");
                }
                else
                {
                    _kosilnica.IsCharging = false;
                    _kosilnica.IsMoving = false;
                }
            }

            if (_kosilnica.BatteryLevel < 10 && _kosilnica.BatteryAutoCharge && !_kosilnica.IsCharging)
            {
                _kosilnica.IsCharging = true;
                _kosilnica.IsMoving = false;
            }
            else if (_kosilnica.TemperatureSensor.Temperature > 10 && _kosilnica.TemperatureSensor.Temperature < 35 &&
                     _kosilnica.LightSensor.IsLight && !_kosilnica.RainSensor.IsRain)
            {
                _kosilnica.IsCharging = false;
                _kosilnica.Power = true;
                _kosilnica.IsMoving = true;
            }
            else
            {
                _kosilnica.IsCharging = false;
                _kosilnica.IsMoving = false;
            }

            if (_kosilnica.Power && _kosilnica.IsMoving)
            {
                if (_kosilnica.MotionSensor.IsObstacleOnFront)
                {
                    return new ResponseMessage(true, "Kosilnica deluje. Deluje s 70% moči, saj se izogiba oviram.");
                }

                return new ResponseMessage(true, "Kosilnica deluje s polno močjo.");
            }

            return new ResponseMessage(_kosilnica.Power, "Kosilnica je v mirujočem stanju.");
        }

        public ResponseMessage RaiseCuttingLevel()
        {
            if (_kosilnica.CuttingLevel >= 7)
            {
                throw new FaultException($"Dosegli ste najvišjo raven prireza trave. Višina prireza je {_kosilnica.CuttingLevel} cm.");
            }

            _kosilnica.CuttingLevel += 0.2;
            return new ResponseMessage(true, $"Višina prireza trave je {_kosilnica.CuttingLevel} cm");
        }

        public ResponseMessage LowerCuttingLevel()
        {
            if (_kosilnica.CuttingLevel <= 1.6)
            {
                throw new FaultException($"Dosegli ste najnižjo raven prireza trave. Višina prireza je {_kosilnica.CuttingLevel} cm.");
            }

            _kosilnica.CuttingLevel -= 0.2;
            return new ResponseMessage(true, $"Višina prireza trave je {_kosilnica.CuttingLevel} cm");
        }

        public void SetPowerOnOff()
        {
            _kosilnica.Power = !_kosilnica.Power;
        }

        public void SetBatteryAutoChargeOnOff()
        {
            _kosilnica.BatteryAutoCharge = !_kosilnica.BatteryAutoCharge;
        }

        public MotionSensor GetMotionSensorData()
        {
            return _kosilnica.MotionSensor;
        }

        public TemperatureSensor GetTemperatureSensorData()
        {
            return _kosilnica.TemperatureSensor;
        }

        public LightSensor GetLightSensorData()
        {
            return _kosilnica.LightSensor;
        }

        public RainSensor GetRainSensorData()
        {
            return _kosilnica.RainSensor;
        }

        public string SendError(string verified)
        {
            throw new FaultException<InvalidData>(new InvalidData(verified, 400), new FaultReason(verified));
        }
    }
}