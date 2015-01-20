using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using pfw.Controller.Base;

namespace pfw.SDK.DataContracts
{
    [DataContract]
    public class EntityResponse
    {
        public EntityResponse()
        {
        }

        [DataMember]
        public long EntityId { get; set; }

        [DataMember]
        public EntityTypeName EntityTypeName { get; set; }
    }
}
