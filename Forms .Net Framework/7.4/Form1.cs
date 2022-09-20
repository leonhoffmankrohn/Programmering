using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            int antal = int.Parse(tbxAntal.Text);

            if (antal <= 10)
            {
                lblSvar.Text = "Kostnaden för " + antal + " skivor är " + antal * 9.90 + " kronor";
            }
            else if (antal > 100)
            {
                lblSvar.Text = "Kostnaden för " + antal + " skivor är " + antal * 8.415 + " kronor";
            }
            else if (antal > 10) {
                lblSvar.Text = "Kostnaden för " + antal + " skivor är " + antal * 8.91 + " kronor";
            }
        }

        private void tbxAntal_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
