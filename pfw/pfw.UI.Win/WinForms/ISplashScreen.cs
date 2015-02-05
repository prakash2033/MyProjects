using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pfw.UI.Win.WinForms
{
    public interface ISplashScreen
    {
        void SetStatusInfo(string NewStatusInfo);

        void ProcessCommand(Enum cmd, object arg);

    }
}
