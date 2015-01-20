using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Controller.Manager;
using pfw.Controller.Base;
using pfw.Model.Managers;
using pfw.Controller.Resources;

namespace pfw.Service.Helpers
{
    public class EntityManagerHelper
    {
        public static EntityManager CreateManager(EntityTypeName entityTypeName)
        {
            var manager = (EntityManager)null;
            //
            switch (entityTypeName)
            {
                case EntityTypeName.Item:
                    return new MasterEntityManager();
                default:
                    throw new NotImplementedException(string.Format(StringResource.ENTITYMANAGER_NOT_IMPLEMENTED, entityTypeName.ToString()));
            }
            //
            return manager;
        }
    }
}
