using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxLiter_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double liter = double.Parse(tbxLiter.Text);
            double kvar = 50 - liter;
            if (double.Parse(tbxLiter.Text) < 10)
            {
                lblSvar.Text = "Tanka " + kvar.ToString() + " liter. Det kostar " + kvar * 14.50 + " kr.";
            }
            else { 

            }
        }
    }
}
