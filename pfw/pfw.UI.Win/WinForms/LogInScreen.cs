using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pfw.UI.Win.WinForms
{
    #region Enum

    public enum LoginScreenCommands
    {
        SetStatus = 1,
        SetCancelCallback = 2,
        ShowLogComponents = 4,
        SetLogInSuccessful = 5,
        SetLogInUnSuccessful = 6,
        Hide = 7,
        DisableAutoLogIn = 8
    }

    #endregion

    public delegate void DoLogInCallEventHandler(string userName, string password, string serverAddress);

    public delegate void CancelLogInCallEventHandler();

    public partial class LogInScreen : WinForm, ISplashScreen
    {
        private DoLogInCallEventHandler _doLogInEventHandler;
        private CancelLogInCallEventHandler _cancelLogInEventHandler;

        #region Properties

        [DefaultValue(null)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DoLogInCallEventHandler DoLogInCallBack
        {
            get
            {
                return _doLogInEventHandler;
            }
            set
            {
                _doLogInEventHandler = value;
            }
        }

        [DefaultValue(null)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CancelLogInCallEventHandler CancelLogInCallBack
        {
            get
            {
                return _cancelLogInEventHandler;
            }
            set
            {
                _cancelLogInEventHandler = value;
            }
        }

        #endregion

        public LogInScreen()
            : base()
        {
            InitializeComponent();
        }

        public override void UnBindEventHandlers()
        {
            base.UnBindEventHandlers();
            this.FormClosed -= new FormClosedEventHandler(LogInScreen_FormClosed);
            btnConnect.Click -= new EventHandler(btnConnect_Click);
            btnCancel.Click -= new EventHandler(btnCancel_Click);
        }

        #region ISplashScreen Memmers

        void ISplashScreen.SetStatusInfo(string NewStatusInfo)
        {
            lblStatus.Text = NewStatusInfo;
        }

        void ISplashScreen.ProcessCommand(Enum cmd, object arg)
        {
            var action = (LoginScreenCommands)cmd;
            if (action == LoginScreenCommands.SetStatus)
            {
                if (this is ISplashScreen)
                    (this as ISplashScreen).SetStatusInfo((string)arg);
                //SetStatus((string)arg);
            }
            else if (action == LoginScreenCommands.SetCancelCallback)
                SetCancelCallback((CancelLogInCallEventHandler)arg);
            else if (action == LoginScreenCommands.ShowLogComponents)
                ShowLogIn(arg as DoLogInCallEventHandler);
            else if (action == LoginScreenCommands.SetLogInSuccessful)
                SetLogInSuccessful();
            else if (action == LoginScreenCommands.SetLogInUnSuccessful)
                SetLogInUnSuccessful();
            else if (action == LoginScreenCommands.DisableAutoLogIn)
                DisableAutoLogin();
        }

        #endregion

        public override void BindEventHandlers()
        {
            base.BindEventHandlers();
            this.FormClosed += new FormClosedEventHandler(LogInScreen_FormClosed);
            btnConnect.Click += new EventHandler(btnConnect_Click);
            btnCancel.Click += new EventHandler(btnCancel_Click);
        }

        void LogInScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void btnConnect_Click(object sender, EventArgs e)
        {
            //
            DoLogIn();
            //
            if (!string.IsNullOrEmpty(txtUsername.Text))
                txtPassword.Select();
            //
            _doLogInEventHandler(txtUsername.Text, txtPassword.Text, cmbServerAddress.Text);
            //
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            CancelLogIn();
        }

        private void CancelLogIn()
        {
            if (_cancelLogInEventHandler != null)
                _cancelLogInEventHandler.Invoke();
        }

        private void DoLogIn()
        {
            //EODLogInComponents(false);
            HideLogInComponents();
            //
            string password = txtPassword.Text;
            //if (pfw.UI.Win.Properties.Settings.Default.RememberPassword && password == DISPLAY_PASSWORD)
            //    password = CrypTo.DecryptString(Excellon.FW5.UI.Win.Forms.Properties.Settings.Default.SavedPassword);
            //
            _doLogInEventHandler(txtUsername.Text, password, cmbServerAddress.Text);
        }

        public void SetStatus(string text)
        {
            lblStatus.Text = text;
        }

        public void SetCancelCallback(CancelLogInCallEventHandler cancelCallback)
        {
            _cancelLogInEventHandler = cancelCallback;
        }

        public void ShowLogIn(DoLogInCallEventHandler doLogInCallBack)
        {
            _doLogInEventHandler = doLogInCallBack;
            ////
            //LoadDefaults();
            //ValidateData();
            //if (CanDoAutoLogin())
            //    DoLogIn();
            //else
            //{
            //    ShowLogInComponents();
            //    EODLogInComponents(true);
            //    BringToFocus();
            //}
        }

        public void SetLogInSuccessful()
        {
            //SaveDefaults();
            HideLogInComponents();
            //EnableAutoLogin();
        }

        public void SetLogInUnSuccessful()
        {
            //EODLogInComponents(true);
            //DisableAutoLogin();
        }

        private void HideLogInComponents()
        {
            Application.DoEvents();
        }

        private void DisableAutoLogin()
        {
            try
            {
                //Properties.Settings.Default.DisableAutoLogIn = true;
                //Properties.Settings.Default.Save();
            }
            catch { }
        }
    }
}
