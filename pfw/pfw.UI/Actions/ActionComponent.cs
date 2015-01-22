using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.EntityServiceReference;
using pfw.UI.WinForms;

namespace pfw.UI.Actions
{
    /// <summary>
    /// This is action component.
    /// </summary>
    public class ActionComponent : IActionComponent
    {
        [System.ComponentModel.DefaultValue(ActionCommandTypes.None)]
        public ActionCommandTypes ActionCommandType { get; set; }
        //
        public EntityTypeName ActionEntityType { get; set; }
        public FormTypes FormType { get; set; }
        //
        public string ExecuteFunctionName { get; set; }
        public string ExecuteSP { get; set; }
        //
    }
}
