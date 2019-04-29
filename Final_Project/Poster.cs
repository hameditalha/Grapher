using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Poster : Form
    {
        public Poster()
        {
            InitializeComponent();
        }
        static int a;
        private void timerChange_Tick(object sender, EventArgs e)
        {
            a++;
            if (a>=30)
            {
                this.Hide();
                WelcomeWindow ww = new WelcomeWindow();
                ww.Show();
                timerChange.Enabled = false;
            }
        }
    }
}
