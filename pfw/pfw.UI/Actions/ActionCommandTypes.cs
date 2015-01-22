using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pfw.UI.Actions
{
    [Serializable]
    public enum ActionCommandTypes
    {
        None = 0,
        //
        Navigate = 1,
        New = 2,
        Edit = 3,
        //
        Save = 4,
        Delete = 5,
        Cancel = 6,
        Refresh = 7,
        //
        ExecuteFunction = 8,
        ExecuteSP = 9,
        //
        Close = 10,
        Exit = 11,
    }
}
