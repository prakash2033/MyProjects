using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pfw.UI.Win.Managers;

namespace pfw.UI.Win
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
            
            Run();
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
            Environment.Load();
            //
        }

        private static void RunApplication()
        {
            //
            try
            {
                if (SessionManager.Load())
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
