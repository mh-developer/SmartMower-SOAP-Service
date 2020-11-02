using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class TemperatureSensor : Sensor
    {
        [DataMember] public int Temperature { get; set; }
    }
}