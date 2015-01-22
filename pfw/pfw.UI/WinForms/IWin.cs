using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Managers;
using pfw.UI.EntityServiceReference;

namespace pfw.UI.WinForms
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
