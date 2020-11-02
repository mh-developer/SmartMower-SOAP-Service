using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class MotionSensor : Sensor
    {
        [DataMember] public bool IsObstacleOnFront { get; set; }
    }
}