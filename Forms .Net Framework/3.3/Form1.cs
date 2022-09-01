using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnKör_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbxA.Text), b = double.Parse(tbxB.Text), c = double.Parse(tbxC.Text);
            lblSumma.Text = "Summan: " + (a + b + c).ToString();
            lblMedel.Text = "Medelvärdet:" + ((a+b+c)/3).ToString();

        }
    }
}
