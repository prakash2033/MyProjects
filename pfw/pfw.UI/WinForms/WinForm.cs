using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pfw.UI.Managers;
using pfw.UI.EntityServiceReference;

namespace pfw.UI.WinForms
{
    public partial class WinForm : Form, IWin
    {
        private ActionMenuManager _ActionMenuManager;

        public EntityTypeName DefaultEntityType { get; set; }
        [BrowsableAttribute(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ActionMenuManager ActionMenuManager
        {
            get
            {
                return _ActionMenuManager;
            }
        }

        public WinForm()
        {
            InitializeComponent();
            _ActionMenuManager = new ActionMenuManager();
            BindEventHandlers();
        }

        private void BindEventHandlers()
        {
            _ActionMenuManager.BindTo(this);
        }

    }
}
