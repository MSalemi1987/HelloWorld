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
    }
}
