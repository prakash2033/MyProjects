using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Actions;
using pfw.UI.WinForms;
using System.ComponentModel;

namespace pfw.UI.Managers
{
    #region ActionEventHaldler

    public delegate void ActionEventHandler(object sender, ActionEventArgs e);

    public class ActionEventArgs : EventArgs
    {
        public ActionEventArgs(IActionComponent actionComponent)
        {
            ActionComponent = actionComponent;
        }

        public IActionComponent ActionComponent { get; set; }
    } 

    #endregion

    public class ActionMenuManager
    {
        public event ActionEventHandler PerformAction;

        public IWin Win { get; set; }

        public void BindTo(IWin win)
        {
            //
            BindToWin(win);
            //
        }

        private void BindToWin(IWin win)
        {
            Win = win;
            if (Win is INotifyPropertyChanged)
                (Win as INotifyPropertyChanged).PropertyChanged += new PropertyChangedEventHandler(OnWinPropertyChanged);
        }

        private void OnWinPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "")
            { }
        }

        internal void OnPerformAction(IActionComponent actionComponent)
        {
            if (PerformAction != null && actionComponent != null && actionComponent.ActionCommandType != ActionCommandTypes.None)
                PerformAction(this, new ActionEventArgs(actionComponent));
        }

        public void RaisePerformAction(IActionComponent action)
        {
            OnPerformAction(action);
        }
    }
}
