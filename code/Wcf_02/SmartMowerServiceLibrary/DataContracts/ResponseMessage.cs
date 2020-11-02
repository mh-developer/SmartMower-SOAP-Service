using System.Runtime.Serialization;

namespace SmartMowerServiceLibrary.DataContracts
{
    [DataContract]
    public class ResponseMessage
    {
        public ResponseMessage(bool isSuccessStatus, string message)
        {
            IsSuccessStatus = isSuccessStatus;
            Message = message;
        }

        [DataMember] public bool IsSuccessStatus { get; set; }
        [DataMember] public string Message { get; set; }
    }
}