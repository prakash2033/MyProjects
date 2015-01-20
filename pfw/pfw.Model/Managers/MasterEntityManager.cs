using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Manager;
using pfw.Controller.Base;
using pfw.Controller.Entities;

namespace pfw.Model.Managers
{
    public class MasterEntityManager : EntityManager
    {
        public override EntityBase GetEntity(EntityTypeName entityTypeName)
        {
            switch (entityTypeName)
            {
                case Controller.Base.EntityTypeName.Item:
                    return new pfw.Model.Masters.Item(this);
                default:
                    throw new NotImplementedException("Entity not implemented.");
            }
        }

        public override void CreateManager()
        {
            
        }
    }
}
