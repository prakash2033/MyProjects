using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pfw.UI.Win.Actions;
using pfw.UI.Win.WinForms;
using pfw.ServiceAgent.EntityServiceReference;

namespace pfw.UI.Win.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public partial class pButton : Button, IActionComponent
    {
        #region Constructors

        public pButton()
        {
            InitializeComponent();
            UnBindEventHandlers();
            BindEventHandlers();
            SetDefaults();
        }

        public pButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            SetDefaults();
            UnBindEventHandlers();
            BindEventHandlers();
        } 

        #endregion

        #region IActionComponent Members

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

        #endregion

        private void SetDefaults()
        {

        }

        private void BindEventHandlers()
        {
            this.Click += new EventHandler(pButton_Click);
        }

        private void UnBindEventHandlers()
        {
            this.Click -= new EventHandler(pButton_Click);
        }

        void pButton_Click(object sender, EventArgs e)
        {
            var form = this.Parent.FindForm() as WinForms.WinForm;
            if (form != null)
                form.ActionMenuManager.RaisePerformAction(this);
        }
    }
}
