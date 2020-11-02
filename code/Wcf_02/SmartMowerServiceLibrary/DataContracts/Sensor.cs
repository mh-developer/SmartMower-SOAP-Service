using System;
using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class Sensor
    {
        [DataMember] public string Name { get; set; }
        [DataMember] public string Value { get; set; }
        [DataMember] public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}