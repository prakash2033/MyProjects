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
            ShowLoginScreen();
            LogIn();
            WaitForLogIn();
            return IsLoggedOn;
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

        private static void ShowLoginScreen()
        {

        }

        private static void LogIn()
        {
            
        }
    }
}
