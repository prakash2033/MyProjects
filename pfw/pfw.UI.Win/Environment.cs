using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.WinForms;

namespace pfw.UI.Win
{
    public class Environment
    {
        #region Variables

        private static IWin _DefaultMainWin;
        private static IWin _EntityView;
        private static SplashScreen _SplashScreen;
        private static LogInScreen _LogInScreen;

        #endregion

        #region Properties

        public static IWin MainWin
        {
            get
            {
                if (_DefaultMainWin == null)
                    _DefaultMainWin = new MdiForm();
                //
                return _DefaultMainWin;
            }
        }

        public static IWin EntityView
        {
            get
            {
                if (_EntityView == null || (_EntityView as WinForm).IsDisposed)
                    _EntityView = new WinForm();
                return _EntityView;
            }
        }

        public static SplashScreen SplashScreen
        {
            get
            {
                if (_SplashScreen == null)
                    _SplashScreen = new SplashScreen();
                //
                _SplashScreen.timer.Tick -= new EventHandler(SplashScreen_Timer_Tick);
                _SplashScreen.timer.Tick += new EventHandler(SplashScreen_Timer_Tick);
                //
                return _SplashScreen;
            }
        }



        public static LogInScreen LogInScreen
        {
            get
            {
                if (_LogInScreen == null)
                    _LogInScreen = new LogInScreen();
                return _LogInScreen;
            }
        }

        #endregion

        public static void Load()
        {
            LogInScreen.Show();
            //SplashScreen.ShowDialog();
            //System.Windows.Forms.Application.Run(SplashScreen);
        }

        static void SplashScreen_Timer_Tick(object sender, EventArgs e)
        {
            //
            SplashScreen.timer.Stop();
            //
            SplashScreen.Hide();
            //
            LogInScreen.ShowDialog();
            //
        }
    }
}
