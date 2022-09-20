using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int ålder = int.Parse(tbxÅlder.Text);/*
            if (ålder < 65 && ålder > 15) {
                lblSvar.Text = "Resan kostar 20 kronor";
            }
            else{
                lblSvar.Text = "Resan kostar 10 kronor";
            }*/
            if (ålder >= 65 || ålder <= 15)
            {
                lblSvar.Text = "Resan kostar 10 kronor";
            }
            else {
                lblSvar.Text = "Resan kostar 20 kronor";
            }

        }
    }
}
