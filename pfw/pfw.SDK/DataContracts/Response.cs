using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace pfw.SDK.DataContracts
{
    [DataContract]
    public class Response
    {
        [DataMember]
        public bool IsRequestSuccessful { get; set; }

        [DataMember]
        public byte[] TimeStamp { get; set; }

        [DataMember]
        public string LastErrorTitle { get; set; }

        [DataMember]
        public string LastErrorMessage { get; set; }

        [DataMember]
        public string LastErrorDetails { get; set; }

        //[DataMember]
        //public ApplicationErrorCodes ErrorCode { get; set; }

        [DataMember]
        public string ErrorID { get; set; }

        [DataMember]
        public string RequestKey { get; set; }

        [DataMember]
        public long ServerProcessingTicks { get; set; }

        [DataMember]
        public string ProcessingServer { get; set; }
    }
}
