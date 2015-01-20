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
    public partial class WinForm : Form
    {
        #region Constructor

        public WinForm()
        {
            InitializeComponent();
        }

        public WinForm(EntityManager entityManager, EntityBase entityBase)
        {
            InitializeComponent();
            EntityManager = entityManager;
            EntityBase = entityBase;
        } 

        #endregion

        #region Public Properties

        public EntityManager EntityManager { get; set; }
        public EntityBase EntityBase { get; set; }
        
        #endregion
    }
}
