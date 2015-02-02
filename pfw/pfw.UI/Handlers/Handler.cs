using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pfw.UI.Win.WinForms;
using pfw.UI.Win.Actions;
using System.Windows.Forms;
using pfw.UI.Win.Managers;

namespace pfw.UI.Win.Handlers
{
    public abstract class Handler
    {
        public EntityManager EntityManager { get; private set; }

        //
        public IActionComponent OriginalAction { get; private set; }
        public IActionComponent InvokedAction { get; private set; }
        //
        public virtual IWin Win { get; private set; }
        public virtual WinForm WinForm { get { return Win as WinForm; } }
        protected abstract IWin CreateWinForm();

        public Handler(IActionComponent action)
        {
            OriginalAction = action;
            InvokedAction = action.Clone();
            //
            if (Win == null)
                Win = CreateWinForm();
            //
            ShowWinForm();
            BindFormEventHandlers();
            BindManagerEventHandlers();
        }

        protected virtual void ShowWinForm()
        {
            if (WinForm == null)
                return;

            switch (InvokedAction.FormType)
            {
                case FormTypes.NewMDIChild:
                    WinForm.ShowInTaskbar = false;
                    WinForm.MdiParent = Environment.MainHandler.MainWinForm;
                    WinForm.Show();
                    break;
            }
        }

        protected virtual void BindFormEventHandlers()
        {
            if (WinForm == null)
                return;
            //
            WinForm.FormClosing += OnFormClosing;
            WinForm.FormClosed += OnFormClosed;
        }

        protected virtual void UnBindFormEventHandlers()
        {
            if (WinForm == null)
                return;
            //
            WinForm.FormClosing -= OnFormClosing;
            WinForm.FormClosed -= OnFormClosed;
        }

        protected virtual void BindManagerEventHandlers()
        {
            Win.ActionMenuManager.PerformAction += OnPerformAction;
        }

        protected virtual void UnBindManagerEventHandlers()
        {
            if (Win.ActionMenuManager != null)
                Win.ActionMenuManager.PerformAction -= OnPerformAction;
        }

        private void OnPerformAction(object sender, ActionEventArgs e)
        {
            PerformAction(e.ActionComponent);
        }

        public virtual void PerformAction(IActionComponent actionComponent)
        {
            try
            {
                switch (actionComponent.ActionCommandType)
                {
                    case ActionCommandTypes.New:
                        PerformAction_New(actionComponent);
                        break;
                    case ActionCommandTypes.Save:
                        //PerformAction_Save(actionComponent);
                        break;
                    case ActionCommandTypes.Close:
                        //PerformAction_Close(actionComponent);
                        break;
                    case ActionCommandTypes.Refresh:
                        //PerformAction_RefreshEntity(actionComponent);
                        break;
                    case ActionCommandTypes.Exit:
                        //PerformAction_Exit(actionComponent);
                        break;
                    case ActionCommandTypes.Navigate:
                        PerformAction_Navigate(actionComponent);
                        break;
                    case ActionCommandTypes.Edit:
                        //PerformAction_Edit(actionComponent);
                        break;
                    case ActionCommandTypes.Delete:
                        //PerformAction_Delete(actionComponent);
                        break;
                    case ActionCommandTypes.Cancel:
                        //PerformAction_Cancel(actionComponent);
                        break;
                    case ActionCommandTypes.ExecuteFunction:
                    //PerformAction_ExecuteFunction(actionComponent);
                    case ActionCommandTypes.ExecuteSP:
                        //PerformAction_ExecuteSP(actionComponent);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
        }

        public static Handler NewHandler(IActionComponent actionComponent)
        {
            return new EntityHandler(actionComponent);
        }

        private void PerformAction_Navigate(IActionComponent actionComponent)
        {
            PerformNavigate(actionComponent);
        }

        private void PerformAction_New(IActionComponent actionComponent)
        {
            PerformNew(actionComponent);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosing(e);
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeComponents();
        }

        protected virtual void PerformClose()
        {
            try
            {
                Win.Close();
            }
            catch { };
        }

        protected virtual void FormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = false;
        }

        protected virtual void DisposeComponents()
        {
            try
            {
                UnBindManagerEventHandlers();
                UnBindFormEventHandlers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
            }
        }

        protected abstract void PerformNavigate(IActionComponent actionComponent);
        protected abstract void PerformNew(IActionComponent actionComponent);
    }
}
