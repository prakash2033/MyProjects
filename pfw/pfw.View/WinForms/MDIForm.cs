using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pfw.Controller.Manager;
using pfw.Controller.Base;

namespace pfw.View.WinForms
{
    public partial class MDIForm : Form
    {
        EntityManager entityManager;
        public MDIForm()
        {
            InitializeComponent();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entityManager = new pfw.Model.Managers.MasterEntityManager();
            EntityBase entityBase = entityManager.GetEntity(Controller.Base.EntityTypeName.Item);
            WinForm wf = new WinForm(entityManager, entityBase);
            wf.MdiParent = this;
            wf.Show();
        }
    }
}
