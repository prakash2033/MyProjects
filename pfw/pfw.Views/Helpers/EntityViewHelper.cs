using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.Views.Base;
using pfw.Views.Resources;
using pfw.UI.Win.WinForms;

namespace pfw.Views.Helpers
{
    public class EntityViewHelper
    {
        public static WinForm GetLayout(EntityViewName entityViewName)
        {
            switch (entityViewName)
            {
                case EntityViewName.AllItems:
                    return new pfw.Views.EntityViews.Masters.Catalog.AllItemView();
                case EntityViewName.Item:
                    return new pfw.Views.EntityViews.Masters.Entity.ItemView();
                default:
                    throw new NotImplementedException(string.Format(StringResource.LAYOUT_NOT_IMPLEMENTED, entityViewName.ToString()));
            }
        }
    }
}
