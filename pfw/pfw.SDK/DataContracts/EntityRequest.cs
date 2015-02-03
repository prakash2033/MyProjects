using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using pfw.Controller.Base;
using pfw.Controller.Manager;

namespace pfw.SDK.DataContracts
{
    [DataContract]
    public class EntityRequest : Request
    {
        public EntityRequest()
        { }

        [DataMember]
        public long EntityId { get; set; }

        [DataMember]
        public EntityTypeName EntityTypeName { get; set; }

        [DataMember]
        public EntityManager EntityManager { get; set; }
    }
}
