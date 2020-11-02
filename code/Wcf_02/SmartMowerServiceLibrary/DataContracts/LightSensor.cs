using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class LightSensor : Sensor
    {
        [DataMember] public bool IsLight { get; set; }
    }
}