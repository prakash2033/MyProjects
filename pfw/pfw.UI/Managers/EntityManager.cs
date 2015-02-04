using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.ServiceAgent.EntityServiceReference;

namespace pfw.UI.Managers
{
    public class EntityManager
    {
        public static string ServerAddress { get; private set; }

        public delegate void RemoteCallFailed(Request request, Exception error);

        public delegate void RemoteCallCompleted(Request request, Response response);

        public static bool SetUp(string serverAddress)
        {
            return true;
        }

        public void LogIn(LogInRequest request, RemoteCallCompleted completedCallback, RemoteCallFailed failedCallback)
        {
            var rc = BeginRemoteCall(request);
            //
            try
            {
                //var reponse = rc.Client.LogIn(request);
                //EndRemoteCall(rc, reponse);
                //completedCallback(request, reponse);
            }
            catch (Exception ex)
            {
                //EndRemoteCall(rc, ex);
                failedCallback(request, ex);
            }
        }

        private object BeginRemoteCall(LogInRequest request)
        {
            return null;
        }
    }

    #region Event Invoking

    public delegate void RequestStartedEventHandler(object sender, RequestStartedArgs e);

    public delegate void RequestCompletedEventHandler(object sender, RequestCompletedArgs e);

    public class RequestStartedArgs : EventArgs
    {
        public RequestStartedArgs(Request request)
        {
            Request = request;
        }

        public Request Request { get; private set; }
    }

    public class RequestCompletedArgs : EventArgs
    {
        public RequestCompletedArgs(Request request, Response response)
        {
            Request = request;
            Response = response;
        }

        public Request Request { get; private set; }
        public Response Response { get; private set; }
    }

    #endregion
}
