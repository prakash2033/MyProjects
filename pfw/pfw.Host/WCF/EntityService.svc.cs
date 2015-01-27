using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using pfw.SDK.DataContracts;
using pfw.Host.Helpers;
using pfw.SDK.Entities;

namespace pfw.Host.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EntityService" in code, svc and config file together.
    public class EntityService : IEntityService
    {
        public ActionResponse EntityAction(ActionRequest request)
        {
            return new EntityServiceContext(request).EntityAction();
        }


        public EntityResponse Layout(EntityRequest request)
        {
            return null;
        }

        public EntityResponse Entity(EntityRequest request)
        {
            if (request != null)
                request.EntityManager = EntityManagerHelper.CreateManager(request.EntityTypeName);

            return new EntityServiceContext(request).Entity();
        }
    }
}
