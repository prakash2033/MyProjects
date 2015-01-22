using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Base;
using pfw.Controller.Manager;

namespace pfw.Controller.Data
{
    [Serializable]
    public class DataEntity : EntityBase
    {
        #region Constructor

        public DataEntity(EntityTypeName typeName, EntityManager entityManager)
            : base(typeName, entityManager)
        { } 

        #endregion
    }
}
