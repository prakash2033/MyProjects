﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.WinForms;
using pfw.UI.Win.Actions;
using pfw.ServiceAgent.EntityServiceReference;

namespace pfw.UI.Win.Actions
{
    public interface IActionComponent
    {
        ActionCommandTypes ActionCommandType { get; set; }
        EntityTypeName ActionEntityType { get; set; }
        FormTypes FormType { get; set; }
        string ExecuteFunctionName { get; set; }
        string ExecuteSP { get; set; }
    }

    public static class ActionExtension
    {
        public static ActionComponent Clone(this IActionComponent action)
        {
            return new ActionComponent() 
            { 
                ActionCommandType = action.ActionCommandType, 
                ActionEntityType = action.ActionEntityType, 
                FormType = action.FormType, 
                ExecuteFunctionName = action.ExecuteFunctionName, 
                ExecuteSP = action.ExecuteSP 
            };
        }
    }
}
