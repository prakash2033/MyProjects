using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.WinForms;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace pfw.UI.Win.Managers
{
    public class SplashScreenManager
    {
        private static Form m_SplashForm = null;
        private static ISplashScreen m_SplashInterface = null;
        private static Thread m_SplashThread = null;
        private static string m_TempStatus = string.Empty;

        public static ISplashScreen Default
        {
            get
            {
                return m_SplashForm as ISplashScreen;
            }
        }

        /// <summary>
        /// Show the SplashForm
        /// </summary>
        public static void ShowForm(Type splashFormType)
        {
            if (m_SplashThread != null)
                return;
            if (splashFormType == null)
            {
                throw (new Exception("splashFormType is null"));
            }


            m_SplashThread = new Thread(new ThreadStart(delegate()
            {
                CreateInstance(splashFormType);
                Application.Run(m_SplashForm);
            }));

            m_SplashThread.IsBackground = true;
            m_SplashThread.SetApartmentState(ApartmentState.STA);
            m_SplashThread.Start();
        }

        /// <summary>
        /// set the loading Status
        /// </summary>
        public static string Status
        {
            set
            {
                if (m_SplashInterface == null || m_SplashForm == null)
                {
                    m_TempStatus = value;
                    return;
                }
                m_SplashForm.Invoke(
                        new SplashStatusChangedHandle(delegate(string str) { m_SplashInterface.SetStatusInfo(str); }),
                        new object[] { value }
                    );
            }

        }

        /// <summary>
        /// Close the SplashForm
        /// </summary>
        public static void Close()
        {
            if (m_SplashThread == null || m_SplashForm == null) return;

            try
            {
                m_SplashForm.Invoke(new MethodInvoker(m_SplashForm.Close));
            }
            catch (Exception)
            {
            }
            m_SplashThread = null;
            m_SplashForm = null;
        }

        private static void CreateInstance(Type FormType)
        {
            object obj = FormType.InvokeMember(null,
                                BindingFlags.DeclaredOnly |
                                BindingFlags.Public | BindingFlags.NonPublic |
                                BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
            m_SplashForm = obj as Form;
            m_SplashInterface = obj as ISplashScreen;
            if (m_SplashForm == null)
            {
                throw (new Exception("Splash Screen must inherit from System.Windows.Forms.Form"));
            }
            if (m_SplashInterface == null)
            {
                throw (new Exception("must implement interface ISplashForm"));
            }

            if (!string.IsNullOrEmpty(m_TempStatus))
                m_SplashInterface.SetStatusInfo(m_TempStatus);
        }

        private delegate void SplashStatusChangedHandle(string NewStatusInfo);

    }
}
