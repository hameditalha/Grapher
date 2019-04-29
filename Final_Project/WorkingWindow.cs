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
    public partial class WorkingWindow : Form
    {
        public WorkingWindow()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            WelcomeWindow ww = new WelcomeWindow();
            this.Close();
            ww.Show();
        }

        private void pictureBoxIcon_Click(object sender, EventArgs e)
        {
            WelcomeWindow ww = new WelcomeWindow();
            this.Close();
            ww.Show();
        }

        private void buttonAxies_Click(object sender, EventArgs e)
        {
            Graphics axis = panelGraph.CreateGraphics();
            Pen dark = new Pen(Color.Black, 2);
            float height = panelGraph.Height;
            float width = panelGraph.Width;
            axis.DrawLine(dark, width / 2, 0, width / 2, height);
            axis.DrawLine(dark, 0, height / 2, width, height / 2);
            
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            HideAll();
            panelCircle.Show();
        }

        private void WorkingWindow_Load(object sender, EventArgs e)
        {
            HideAll();
        }
        private void HideAll()
        {
            panelCircle.Hide();
            panelLine.Hide();
        }


        private void DrawCircle(int _x, int _y, int radius, Panel p)
        {
            int height, width;
            height = p.Height;
            width = p.Width;
            Graphics circle = p.CreateGraphics();
            Random r = new Random();
            Color cl = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            Pen pen = new Pen(cl, 2);
            circle.DrawEllipse(pen, ((width / 2) + _x)-radius, ((height / 2) + _y)-radius, radius + radius, radius + radius);
            circle.Dispose();
            pen.Dispose();
        }

        private void buttonPlotCircle_Click(object sender, EventArgs e)
        {
            int g, h, rad;
                g = Convert.ToInt32(textBoxG.Text) * 10;
                h = Convert.ToInt32(textBoxH.Text) * 10;
                rad = Convert.ToInt32(textBoxRadius.Text) * 10;
                DrawCircle(g, h, rad, panelGraph);
        }
        private void buttonLine_Click(object sender, EventArgs e)
        {
            HideAll();
            panelLine.Show();
        }

        private void buttonPlotLine_Click(object sender, EventArgs e)
        {
            int x1 = 0, x2 = 0, y1 = 0, y2 = 0;
            int intercept = Convert.ToInt32(textBoxC.Text) * 10;
            int slope = Convert.ToInt32(textBoxSlope.Text);

            if (slope == 0)
            {
                x1 = 0;
                y1 = y2 = 225 - intercept;
                x2 = 550;

            }
            else if (slope == 1)
            {
                x1 = 225;
                y1 = 0;
                x2 = 225;
                y2 = 550;
            }
            else if (intercept >= 0 && slope != 0 && slope != 1)
            {
                if (slope > 1)
                {
                    /* x1 = 0;
                     y1 = 225 - intercept;
                     x2 = intercept + 225;
                     y2 = 225;*/
                    //x1 = y1 = 0;
                    x1 = 0;
                    y1 = slope * intercept;
                    x2 = 225;
                    y2 = 225 - intercept;
                }
                else if (slope < 0)
                {
                    x1 = 550;
                    y1 = -slope * intercept;
                    x2 = 225;
                    y2 = 225 - intercept;
                }

            }
            else if (intercept <= 0 && slope != 0 && slope != 1)
            {
                if (slope > 1)
                {
                    x2 = 225;
                    y2 = 225 - intercept;
                    y1 = (-intercept);
                    x1 = 0;
                }
                else if (slope < 0)
                {
                    x1 = 225;
                    y1 = -intercept + 225;
                    x2 = 550;
                    y2 = -intercept - slope * intercept;

                    /*x2 = 225;
                    y2 = -intercept;
                    y1 = 225 + (-intercept);
                    x1 = 550;*/
                }
            }


            DrawLine(x1, y1, x2, y2, panelGraph);
        }
        private void DrawLine(int _x1, int _y1, int _x2, int _y2, Panel p)
        {
            Graphics line = p.CreateGraphics();
            Random r = new Random();
            Color cl = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            Pen pen = new Pen(cl, 2);
            line.DrawLine(pen, _x1, _y1, _x2, _y2);
        }

        private void buttonPlotLine1_Click(object sender, EventArgs e)
        {
            int x1, x2, y1, y2;
                x1 = Convert.ToInt32(textBoxX1.Text);
                x2 = Convert.ToInt32(textBoxX2.Text);
                y1 = Convert.ToInt32(textBoxY1.Text);
                y2 = Convert.ToInt32(textBoxY2.Text);

                if (x1 >= 0)
                {
                    x1 += 225;
                }
                if (x2 >= 0)
                {
                    x2 += 225;
                }
                if (y1 == 0)
                {
                    y1 += 225;
                }
                if (y2 == 0)
                {
                    y2 += 225;
                }
                if (y1 < 0)
                {
                    y1 = 550 - y1;
                }
                if (y2 < 0)
                {
                    y2 = 550 - y2;
                }
                if (x1 < 0)
                {
                    x1 *= -1;
                    int a = 225 - x1;
                    x1 = a;
                }
                if (x2 < 0)
                {
                    x2 *= -1;
                    int a = 225 - x2;
                    x2 = a;
                }
                if (y1 > 0)
                {
                    y1 = 225 - y1;
                }
                if (y2 > 0)
                {
                    y1 = 225 - y2;
                }


                DrawLine(x1, y1, x2, y2, panelGraph);


        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            panelGraph.Invalidate();
            HideAll();
        }

        private void buttonClearGraphPanel_Click(object sender, EventArgs e)
        {
            panelGraph.Invalidate();
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
            c.ShowDialog();
        }
    }
}
