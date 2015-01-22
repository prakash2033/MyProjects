using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using pfw.Controller.Base;
using pfw.Controller.Manager;
using pfw.Model.Managers;
using pfw.Controller.Resources;

namespace pfw.Host.Helpers
{
    [Serializable]
    public class EntityManagerHelper
    {
        public static EntityManager CreateManager(EntityTypeName entityTypeName)
        {
            //
            switch (entityTypeName)
            {
                case EntityTypeName.Item:
                    return new MasterEntityManager { EntityTypeName = entityTypeName };
                default:
                    throw new NotImplementedException(string.Format(StringResource.ENTITYMANAGER_NOT_IMPLEMENTED, entityTypeName.ToString()));
            }
            //
        }
    }
}