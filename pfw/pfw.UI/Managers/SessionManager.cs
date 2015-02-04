using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Handlers;
using pfw.ServiceAgent.EntityServiceReference;
using pfw.UI.Win.WinForms;
using System.Windows.Forms;

namespace pfw.UI.Managers
{
    public static class SessionManager
    {
        //
        public static string UserName { get; private set; }
        public static string Password { get; private set; }
        public static long UserID { get; private set; }
        //

        public static string ServerAddress { get; private set; }
        public static string LoginPassword { get; private set; }
        public static string LoginUserName { get; private set; }

        public static bool IsLoggedOn { get; private set; }

        public static MdiHandler MainHandler { get; private set; }

        public static EntityManager EntityManager { get; private set; }

        private static System.Threading.AutoResetEvent WaitForLoginAction;

        public static bool Load()
        {
            InitiliazeVariables();
            LogIn();
            WaitForLogIn();
            return IsLoggedOn;
        }

        public static void Run()
        {
            if (LoadEnvironment())
                ShowEnvironment();
            //else
            //    Forms.Environment.SendCommandToSplashScreen(LoginScreenCommands.DisableAutoLogIn, null);
        }

        private static void ShowEnvironment()
        {
            ShowMainForm();
        }

        private static void ShowMainForm()
        {
            if (MainHandler != null)
                Application.Run(MainHandler.MainWinForm);
        }

        private static bool LoadEnvironment()
        {
            bool isEnvironmentLoaded = false;
            try
            {
                isEnvironmentLoaded =
                    LoadUserEnvironment()
                    && LoadMainWinHandler();
            }
            catch (Exception ex)
            {
                //PromptHelper.PromptErrorCode(ex, null, string.Empty);
            }
            //
            return isEnvironmentLoaded;
        }

        private static bool LoadMainWinHandler()
        {
            MainHandler = new MdiHandler();
            MainHandler.MainWinForm.Load += OnMainFormLoaded;
            MainHandler.MainWinForm.FormClosed += OnMainFormClosed;
            return MainHandler != null;
        }

        private static bool LoadUserEnvironment()
        {
            return true;
        }

        public static void CleanUp()
        {
            try
            {
                HideLoginScreen();
            }
            catch { }
        }

        private static void WaitForLogIn()
        {
            WaitForLoginAction = new System.Threading.AutoResetEvent(false);
            WaitForLoginAction.WaitOne();
        }

        private static void InitiliazeVariables()
        {
            EntityManager = new EntityManager();
        }

        private static void HideLoginScreen()
        {

        }

        private static void LogIn()
        {
            StartLogInProcess((DoLogInCallEventHandler)DoLogIn);
        }

        private static void StartLogInProcess(DoLogInCallEventHandler doLogInCallEventHandler)
        {
            pfw.UI.Win.Environment.LogInScreen.Hide();
        }

        private static void DoLogIn(string userName, string password, string serverAddress)
        {
            if (EntityManager.SetUp(serverAddress))
                DoLogInInternal(userName, password, false);
            //else
            //    DoLogInCompletedConvey();
            //
            ServerAddress = EntityManager.ServerAddress;
        }

        private static bool DoLogInInternal(string userName, string password, bool forceLogin)
        {
            string _lMachineName = System.Environment.MachineName;
            string _lOSuserName = String.Format("{0}@{1}", System.Environment.UserName, System.Environment.UserDomainName);
            LoginUserName = userName;
            LoginPassword = password;
            //
            try
            {
                System.Threading.Tasks.Task.Factory.StartNew(() => EntityManager.LogIn(new LogInRequest() { UserName = userName, Password = password, MachineName = _lMachineName, OSUserName = _lOSuserName, ForceLogin = forceLogin }, DoLogInCompleted, DoLogInFailed));
            }
            catch (Exception)
            {
                //DoLogInFailed(null, ex);
            }
            //
            return true;
        }

        private static void DoLogInCompleted(Request request, Response response)
        {
            var sessionResponse = (LogInResponse)response;
            if (response != null)
            {
                //if (response.IsRequestSuccessful)
                //    LoadSessionData(sessionResponse);
                //else if (sessionResponse.ErrorCode == ApplicationErrorCodes.SessionExceedsQuota && PromptConcurrentSessions(sessionResponse.LastErrorMessage))
                //    return;
            }
            //
            //DoLogInCompletedConvey();
            //
            //if (!IsLoggedOn)
            //    PromptLoginFailed(sessionResponse, null);
        }

        private static void DoLogInFailed(Request request, Exception error)
        {
            //DoLogInCompletedConvey();
            //PromptLoginFailed(null, error);
        }

        private static void OnMainFormLoaded(object sender, EventArgs e)
        {

        }

        private static void OnMainFormClosed(object sender, EventArgs e)
        {

        }
    }
}
