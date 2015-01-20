using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.SDK.DataContracts;

namespace pfw.SDK.Entities
{
    public class EntityServiceContext
    {
        #region Public Properties
        
        public EntityRequest EntityRequest { get; set; }
        
        #endregion

        #region Constructor

        public EntityServiceContext(EntityRequest entityRequest)
        {
            EntityRequest = entityRequest;
        } 

        #endregion
    }
}
