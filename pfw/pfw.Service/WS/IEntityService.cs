using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using pfw.SDK.DataContracts;
using pfw.Controller.Manager;

namespace pfw.Service.WS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEntityService" in both code and config file together.
    [ServiceContract]
    public interface IEntityService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        EntityResponse Entity(EntityRequest request);

        [OperationContract]
        EntityManager Manager(EntityRequest request);
    }
}
