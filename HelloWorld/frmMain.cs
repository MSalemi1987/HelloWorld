using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class frmMain : Form
    {
        private double Pi = 3.14;
        private Double k;
        private Double num1 = 0;
        private Double num2 = 0;
        private string oper;
        public frmMain()
        {
            InitializeComponent();
        }
            private void btn1_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("1");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtshow.AppendText("0");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = Double.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "+";
                txtlog.AppendText(num1.ToString() + "+" );
            }
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = Double.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "-";
                txtlog.AppendText(num1.ToString()  + "-");
            }
        
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num2 = Double.Parse(txtshow.Text);
                txtlog.AppendText(num2.ToString() + "=");
                if (oper == "+")
                {
                    txtshow.Text = (num1 + num2).ToString("0.00");
                    txtlog.AppendText((num1 + num2).ToString("0.00") + Environment.NewLine);
                         }
                else if (oper == "-")
                {
                    txtshow.Text = (num1 - num2).ToString("0.00");
                    txtlog.AppendText((num1 - num2).ToString("0.00") + Environment.NewLine);
                }
                else if (oper == "*")
                {
                    txtshow.Text = (num1 * num2).ToString("0.00");
                    txtlog.AppendText((num1 * num2).ToString("0.00") + Environment.NewLine);
                }
                else if (oper == "/")
                {
                    txtshow.Text = (num1 / num2).ToString("0.00");
                    txtlog.AppendText((num1 / num2).ToString("0.00") + Environment.NewLine);
                }
                else if (oper == "^")
                {
                    txtshow.Text = Math.Pow(num1,num2).ToString("0.00");
                    txtlog.AppendText((Math.Pow(num1, num2)).ToString("0.00") + Environment.NewLine);
                }
                
                 }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                txtshow.Text = txtshow.Text.Remove(txtshow.Text.Length - 1);
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = Double.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "*";
                txtlog.AppendText(num1.ToString() + "*" );
            }
        }

        private void txtlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = Double.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "/";
                txtlog.AppendText(num1.ToString() + "/" );
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtshow.AppendText(".");
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtshow.Text = "";
        }

     
        private void btnPow_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = Double.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "^";
                txtlog.AppendText(num1.ToString() + "^");
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = Double.Parse(txtshow.Text);
                var Result = Math.Sqrt(num1);
                txtshow.Text = Math.Sqrt(num1).ToString();
                oper = "Sqrt";
                txtlog.AppendText("Sqrt(" + num1 + ")=" +Result + Environment.NewLine);
            }
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = int.Parse(txtshow.Text);
                var num2 = num1;
                for (int i = 1; i < num1; i++)
                {
                    num2 = num2 * i;
                }
                txtshow.Text =num2.ToString();
                oper = "!";
                txtlog.AppendText(num1+"!="+num2 + Environment.NewLine);
            }
        }
    }
}
