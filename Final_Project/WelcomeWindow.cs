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
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app is created as a semester project by Talha Ahmed Hamedi under the supervision of Miss Iqra Shafique. This aims to display the abstract idea of what a graph will look like of a given equation.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            WorkingWindow ww = new WorkingWindow();
            this.Hide();
            ww.Show();
        }

        private void buttonFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/talhaahmedhamedi/");
        }

        private void buttonLinedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/talha-ahmed-hamedi-55a541152/");
        }


    }
}
