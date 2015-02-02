using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.Handlers;

namespace pfw.UI.Win.Managers
{
    public static class SessionManager
    {
        //
        public static string UserName { get; private set; }
        public static string Password { get; private set; }
        public static long UserID { get; private set; }
        //

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

        public static bool Run()
        {
            MainHandler = new MdiHandler();
            MainHandler.MainWinForm.Load += OnMainFormLoaded;
            MainHandler.MainWinForm.FormClosed += OnMainFormClosed;
            return MainHandler != null;
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
            
        }

        private static void OnMainFormLoaded(object sender, EventArgs e)
        {

        }

        private static void OnMainFormClosed(object sender, EventArgs e)
        {

        }
    }
}
