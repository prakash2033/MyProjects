using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pfw.UI.Win.WinForms;
using pfw.UI.Win.Actions;

namespace pfw.UI.Win.Handlers
{
    public class MdiHandler : EntityHandler, IWin
    {
        #region Constructor


        public MdiHandler()
            : base(new ActionComponent() { ActionCommandType = ActionCommandTypes.Navigate })
        {

        }

        #endregion

        public IWin MainWin
        {
            get
            {
                return base.Win as IWin;
            }
        }

        public Form MainWinForm
        {
            get
            {
                return base.Win as Form;
            }
        }

        public override IWin Win
        {
            get
            {
                return base.Win as IWin;
            }
        }

        protected override IWin CreateWinForm()
        {
            return Program.MainWin;
        }

        public Managers.ActionMenuManager ActionMenuManager { get; set; }

        public EntityServiceReference.EntityTypeName DefaultEntityType { get; set; }

        public void Close()
        {
            this.Close();
        }
    }
}
