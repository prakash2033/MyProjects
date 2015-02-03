using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pfw.UI.Win.Managers;
using pfw.UI.Win.EntityServiceReference;

namespace pfw.UI.Win.WinForms
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
            UnBindEventHandlers();
            BindEventHandlers();
        }

        public virtual void BindEventHandlers()
        {
            _ActionMenuManager.BindTo(this);
        }

        public virtual void UnBindEventHandlers()
        {
            _ActionMenuManager.BindTo(this);
        }
    }
}
