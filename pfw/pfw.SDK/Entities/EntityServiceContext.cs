using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.SDK.DataContracts;
using pfw.Controller.Manager;
using pfw.Controller.Base;

namespace pfw.SDK.Entities
{
    /// <summary>
    /// This class is used as an agent for entity requests.
    /// </summary>
    [Serializable]
    public class EntityServiceContext
    {
        private EntityManager _Manager;

        #region Public Properties

        public EntityRequest EntityRequest { get; set; }
        public EntityResponse EntityResponse { get; set; }

        public ActionRequest ActionRequest { get; set; }
        public ActionResponse ActionResponse { get; set; }

        public EntityBase EntityBase { get; set; }

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

        /// <summary>
        /// pfw.SDK.EntityServiceContext Constructor with Entity request parameter.
        /// </summary>
        /// <param name="entityRequest"></param>
        public EntityServiceContext(EntityRequest entityRequest)
        {
            EntityRequest = entityRequest;
        }

        /// <summary>
        /// pfw.SDK.EntityServiceContext Constructor with Action request parameter.
        /// </summary>
        /// <param name="actionRequest"></param>
        public EntityServiceContext(ActionRequest actionRequest)
        {
            ActionRequest = actionRequest;
        }

        #endregion

        public EntityResponse Entity()
        {
            EntityResponse = new EntityResponse();

            try
            {
                if (EntityRequest != null && Manager != null)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }

            return EntityResponse;
        }

        public ActionResponse EntityAction()
        {
            ActionResponse = new ActionResponse();

            try
            {
                if (ActionRequest != null && Manager != null)
                {

                }
            }
            catch (Exception)
            {

                throw;
            }

            return ActionResponse;
        }
    }
}
