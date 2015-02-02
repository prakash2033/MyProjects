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
    public delegate void DoLogInCallEventHandler(string userName, string password, string serverAddress);

    public delegate void CancelLogInCallEventHandler();

    public partial class LogInScreen : Form
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
        {
            InitializeComponent();
        }
    }
}
