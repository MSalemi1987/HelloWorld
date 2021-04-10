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
        private int k;
        private int num1 = 0;
        private int num2 = 0;
        private string oper;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            this.k = sum(1, 4);
            Debug.WriteLine(k);
            //MessageBox.Show("Ke=  " + k);


        }

        private int sum(int x, int y)
        {
            int s = x + y;
            return s;

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(this.k);
            MessageBox.Show("Ke=  " + this.k);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var res = "Salam " + txtInput.Text;
            lblResult.Text = res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = txtInput1.Text + "  " + txtInput2.Text;
            lblMerge.Text = res;
        }

        private void Result_Click(object sender, EventArgs e)
        {
            var a = double.Parse(txtFirstNumber.Text) + double.Parse(txtSecondNumber.Text);
            lblSum.Text = a.ToString();
        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

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
                num1 = int.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "+";
                txtlog.AppendText(num1.ToString() + Environment.NewLine + "+" + Environment.NewLine);
            }
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num1 = int.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "-";
                txtlog.AppendText(num1.ToString() + Environment.NewLine + "-" + Environment.NewLine);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtshow.Text.Length > 0)
            {
                num2 = int.Parse(txtshow.Text);
                txtlog.AppendText(num2.ToString() + Environment.NewLine + "=" + Environment.NewLine);
                if (oper == "+")
                {
                    txtshow.Text = (num1 + num2).ToString();
                    txtlog.AppendText((num1 + num2).ToString() + Environment.NewLine);
                }
                else if (oper == "-")
                {
                    txtshow.Text = (num1 - num2).ToString();
                    txtlog.AppendText((num1 - num2).ToString() + Environment.NewLine);
                }
                else if (oper == "*")
                {
                    txtshow.Text = (num1 * num2).ToString();
                    txtlog.AppendText((num1 * num2).ToString() + Environment.NewLine);
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
                num1 = int.Parse(txtshow.Text);
                txtshow.Text = "";
                oper = "*";
                txtlog.AppendText(num1.ToString() + Environment.NewLine + "*" + Environment.NewLine);
            }
        }

      
        
        private void txtlog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
