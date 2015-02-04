using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.ServiceAgent.EntityServiceReference;
using pfw.UI.Win.Actions;
using pfw.UI.Win.WinForms;

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
                    return pfw.UI.Win.Environment.EntityView;
                default:
                    return pfw.UI.Win.Environment.EntityView;
            }
        }
    }
}
