using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace pfw.SDK.DataContracts
{
    [DataContract]
    public class Request
    {
        [DataMember]
        public string AuthenticationToken { get; set; }

        [DataMember]
        public string ManagerKey { get; set; }

        [DataMember]
        public string RequestKey { get; set; }

        [DataMember]
        public int ClientType { get; set; }

        [DataMember]
        public string UserAgent { get; set; }
    }
}
