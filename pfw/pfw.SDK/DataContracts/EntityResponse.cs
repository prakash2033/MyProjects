using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using pfw.Controller.Base;
using pfw.Controller.Data;

namespace pfw.SDK.DataContracts
{
    [DataContract]
    public class EntityResponse : Response
    {
        public EntityResponse()
        {
        }

        [DataMember]
        public long EntityId { get; set; }

        [DataMember]
        public EntityTypeName EntityTypeName { get; set; }

        //[DataMember]
        //public EntityViewName EntityTypeName { get; set; }

        [DataMember]
        public Guid ManagerGuid { get; set; }
    }
}
