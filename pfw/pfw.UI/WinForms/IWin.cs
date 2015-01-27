using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.Managers;
using pfw.UI.Win.EntityServiceReference;

namespace pfw.UI.Win.WinForms
{
    public interface IWin
    {
        //
        ActionMenuManager ActionMenuManager { get; }
        //
        EntityTypeName DefaultEntityType { get; set; }
        //
        void Close();
    }
}
