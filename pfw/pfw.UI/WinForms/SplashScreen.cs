using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pfw.UI.Win.WinForms
{
    public partial class SplashScreen : Form
    {
        public Timer timer;
        public SplashScreen()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 3000;
            timer.Start();
        }
    }
}
