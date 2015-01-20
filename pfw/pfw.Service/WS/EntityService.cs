using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using pfw.SDK.DataContracts;
using pfw.SDK.Entities;
using pfw.Service.Helpers;

namespace pfw.Service.WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EntityService" in both code and config file together.
    public class EntityService : IEntityService
    {
        //[OperationContract]
        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public SDK.DataContracts.EntityResponse Entity(EntityRequest request)
        {
            return new EntityServiceContext(request).Entity();
        }

        public Controller.Manager.EntityManager Manager(EntityRequest request)
        {
            return EntityManagerHelper.CreateManager(request.EntityTypeName);
        }
    }
}
