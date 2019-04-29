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
    public partial class Calculator : Form
    {
        double output = 0;
        double input1 = 0;
        double input2 = 0;
        string trig;
        string operation = null;
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + button0.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            labelResult.Text = labelResult.Text + buttonPoint.Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            operation = buttonAdd.Text;
            try
            {
                input1 = double.Parse(labelResult.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            labelResult.ResetText();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            operation = buttonSub.Text;
            try
            {
                input1 = double.Parse(labelResult.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            labelResult.ResetText();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            operation = buttonMul.Text;
            try
            {
                input1 = double.Parse(labelResult.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            labelResult.ResetText();
        }

        private void buttonDvd_Click(object sender, EventArgs e)
        {
            operation = buttonDvd.Text;
            try
            {
                input1 = double.Parse(labelResult.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message);
            }
            labelResult.ResetText();
        }
        
        private void buttonTan_Click(object sender, EventArgs e)
        {
            trig = labelResult.Text;
            labelResult.Text = buttonTan.Text + labelResult.Text;
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            trig = labelResult.Text;
            labelResult.Text = buttonSin.Text + labelResult.Text;
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            trig = labelResult.Text;
            labelResult.Text = buttonCos.Text + labelResult.Text;
        }
        static int toogle = 0;
        private void buttonToggle_Click(object sender, EventArgs e)
        {
            toogle++;
            if (toogle ==1)
            {
                labelResult.Text = "-" + labelResult.Text;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                input2 = double.Parse(labelResult.Text);
                output = OperationFunc(input1, input2);
                labelResult.ResetText();
                labelResult.Text = output.ToString();
            }
            catch (FormatException fe)
            {
                if (labelResult.Text.Contains('t'))
                {
                    output = Math.Tan(double.Parse(trig));
                }
                else if (labelResult.Text.Contains('s'))
                {
                    output = Math.Sin(double.Parse(trig));
                }
                else if (labelResult.Text.Contains('c'))
                {
                    output = Math.Cos(double.Parse(trig));
                }
                else if (labelResult.Text.Contains('i'))
                {
                    try
                    {
                        output = 1 / double.Parse(trig);
                    }
                    catch (DivideByZeroException)
                    {
                        output.ToString("Error");
                    }
                }
                else
                {
                    MessageBox.Show(fe.Message);
                }
            }
            finally
            {
                labelResult.Text = output.ToString();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        double OperationFunc(double a, double b)
        {
            switch (operation)
            {
                case "/":
                    {
                        output = a / b;
                        break;
                    }
                case "*":
                    {
                        output = a * b;
                        break;
                    }
                case "+":
                    {
                        output = a + b;
                        break;
                    }
                case "-":
                    {
                        output = a - b;
                        break;
                    }
            }
            return output;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResult.ResetText();
        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            trig = labelResult.Text;
            labelResult.Text = "inv( " + labelResult.Text;
        }



    }
}
