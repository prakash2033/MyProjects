using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.EntityServiceReference;

namespace pfw.UI.Win.Managers
{
    public class EntityManager
    {
    }

    #region Event Invoking

    public delegate void RequestStartedEventHandler(object sender, RequestStartedArgs e);

    public delegate void RequestCompletedEventHandler(object sender, RequestCompletedArgs e);

    public class RequestStartedArgs : EventArgs
    {
        public RequestStartedArgs(EntityRequest request)
        {
            Request = request;
        }

        public EntityRequest Request { get; private set; }
    }

    public class RequestCompletedArgs : EventArgs
    {
        public RequestCompletedArgs(EntityRequest request, EntityResponse response)
        {
            Request = request;
            Response = response;
        }

        public EntityRequest Request { get; private set; }
        public EntityResponse Response { get; private set; }
    }

    #endregion
}
