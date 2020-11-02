using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class RainSensor : Sensor
    {
        [DataMember] public bool IsRain { get; set; }
    }
}