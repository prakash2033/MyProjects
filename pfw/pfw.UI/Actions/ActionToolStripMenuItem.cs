using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using pfw.UI.Win.WinForms;
using pfw.UI.Win.EntityServiceReference;

namespace pfw.UI.Win.Actions
{
    public partial class ActionToolStripMenuItem : ToolStripMenuItem, IActionComponent
    {
        public ActionToolStripMenuItem()
        {
            InitializeComponent();
            UnBindEventHandlers();
            BindEventHandlers();
        }

        public ActionToolStripMenuItem(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            UnBindEventHandlers();
            BindEventHandlers();
        }

        [PropertyTab("Action"), Browsable(true), Description("ActionCommandType"), Category("Action")]
        public ActionCommandTypes ActionCommandType
        {
            get
            {
                return _actionCommandType;
            }
            set
            {
                if (_actionCommandType == value) return;
                _actionCommandType = value;
                //
                Name = value.ToString();
                //
            }
        }
        private ActionCommandTypes _actionCommandType;

        [PropertyTab("Action"), Browsable(true), Description("ActionEntityType"), Category("Action")]
        public EntityTypeName ActionEntityType { get; set; }

        [PropertyTab("Action"), Browsable(true), Description("FormType"), Category("Action")]
        public FormTypes FormType { get; set; }

        [PropertyTab("Action"), Browsable(true), Description("ExecuteFunctionName"), Category("Action")]
        public string ExecuteFunctionName { get; set; }

        [PropertyTab("Action"), Browsable(true), Description("ExecuteSP"), Category("Action")]
        public string ExecuteSP { get; set; }

        private void UnBindEventHandlers()
        {
            this.Click -= new EventHandler(ActionToolStripMenuItem_Click);
        }

        private void BindEventHandlers()
        {
            this.Click += new EventHandler(ActionToolStripMenuItem_Click);
        }

        void ActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = this.Owner.FindForm() as WinForms.WinForm;
            if (form != null)
                form.ActionMenuManager.RaisePerformAction(this);
        }
        
    }
}
