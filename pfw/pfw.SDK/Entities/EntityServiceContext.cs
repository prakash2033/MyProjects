using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.SDK.DataContracts;
using pfw.Controller.Manager;

namespace pfw.SDK.Entities
{
    public class EntityServiceContext
    {
        private EntityManager _Manager;

        #region Public Properties

        public EntityRequest EntityRequest { get; set; }
        public EntityResponse EntityResponse { get; set; }

        public EntityManager Manager
        {
            get
            {
                if (_Manager == null && EntityRequest != null)
                    _Manager = EntityRequest.EntityManager;
                return _Manager;
            }
        }

        #endregion



        #region Constructor

        public EntityServiceContext(EntityRequest entityRequest)
        {
            EntityRequest = entityRequest;
        }

        #endregion

        public EntityResponse Entity()
        {
            EntityResponse = new EntityResponse();

            try
            {
                if (EntityRequest != null && Manager!=null)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }

            return EntityResponse;
        }
    }
}
