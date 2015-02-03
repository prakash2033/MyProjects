using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace pfw.SDK.DataContracts
{
    [DataContract]
    public class LogInRequest : Request
    {

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string MachineName { get; set; }

        [DataMember]
        public string OSUserName { get; set; }

        [DataMember]
        public bool ForceLogin { get; set; }
    }
}
