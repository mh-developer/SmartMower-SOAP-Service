using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class InvalidData
    {
        public InvalidData(string message, int errorCode)
        {
            Message = message;
            ErrorCode = errorCode;
        }

        [DataMember] public string Message { get; set; }
        [DataMember] public int ErrorCode { get; set; }
    }
}