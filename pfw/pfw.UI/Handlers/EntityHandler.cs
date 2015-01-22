using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Actions;
using pfw.UI.WinForms;
using pfw.UI.EntityServiceReference;

namespace pfw.UI.Handlers
{
    public class EntityHandler : Handler
    {
        #region Constructor

        public EntityHandler(IActionComponent action)
            : base(action)
        {
        }

        #endregion

        protected override void PerformNavigate(IActionComponent actionComponent)
        {
            Handler.NewHandler(actionComponent);
        }

        protected override void PerformNew(IActionComponent actionComponent)
        {
            EntityHandler.NewHandler(actionComponent);
        }

        protected override IWin CreateWinForm()
        {
            switch (InvokedAction.ActionEntityType)
            {
                case EntityTypeName.Item:
                    return Program.EntityView;
                default:
                    return Program.EntityView;
            }
        }
    }
}
