using SmartMowerServiceLibrary.DataContracts;
using System.ServiceModel;

namespace SmartMowerServiceLibrary
{
    [ServiceContract(Name = "SmartMower", SessionMode = SessionMode.Required)]
    public interface ISmartMowerService
    {
        [OperationContract]
        SmartMower GetState();

        [OperationContract]
        ResponseMessage GetMowerRunningStatus();

        [OperationContract]
        ResponseMessage RaiseCuttingLevel();

        [OperationContract]
        ResponseMessage LowerCuttingLevel();

        [OperationContract(IsOneWay = true)]
        void SetPowerOnOff();

        [OperationContract(IsOneWay = true)]
        void SetBatteryAutoChargeOnOff();

        [OperationContract]
        MotionSensor GetMotionSensorData();

        [OperationContract]
        TemperatureSensor GetTemperatureSensorData();

        [OperationContract]
        LightSensor GetLightSensorData();

        [OperationContract]
        RainSensor GetRainSensorData();

        [OperationContract]
        [FaultContract(typeof(InvalidData))]
        string SendError(string verified);
    }
}