using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Base;

namespace pfw.Controller.Manager
{
    [Serializable]
    public class EntityManager : Manager, IDisposable
    {
        public override EntityBase GetEntity(EntityTypeName entityTypeName)
        {
            return null;
        }
    }
}
