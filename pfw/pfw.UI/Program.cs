using System;
using System.Collections.Generic;
using System.Linq;
using pfw.UI.Managers;
using System.Windows.Forms;

namespace pfw.UI
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.Run();
        }
        
        private static void Run()
        {
            try
            {
                LoadApplication();
                RunApplication();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void LoadApplication()
        {
            //
            System.Threading.Thread.CurrentThread.Name = "MainAppThread";
            pfw.UI.Win.Environment.Load();
            //
        }

        private static void RunApplication()
        {
            //
            try
            {
                if (!pfw.UI.Win.Environment.LogInScreen.IsDisposed && SessionManager.Load())
                    SessionManager.Run();
            }
            finally
            {
                SessionManager.CleanUp();
            }
            //
        }
        

        
    }
}
