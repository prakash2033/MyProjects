using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using pfw.UI.Win.Handlers;
using pfw.UI.Win.WinForms;

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
            
            Load();
        }

        private static IWin _DefaultMainWin;
        public static MdiHandler MainHandler { get; private set; }

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

        private static IWin _entityView;
        public static IWin EntityView
        {
            get
            {
                if (_entityView == null || (_entityView as WinForm).IsDisposed)
                    _entityView = new WinForm();
                return _entityView;
            }
        }

        public static void Load()
        {
            MainHandler = new MdiHandler();
            MainHandler.MainWinForm.Load += OnMainFormLoaded;
            MainHandler.MainWinForm.FormClosed += OnMainFormClosed;
            Application.Run(MainHandler.MainWinForm);
        }

        private static void OnMainFormLoaded(object sender, EventArgs e)
        {
        }

        private static void OnMainFormClosed(object sender, EventArgs e)
        {
        }
    }
}
