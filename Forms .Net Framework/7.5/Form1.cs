using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            switch (int.Parse(tbxVeckodagNr.Text)) {
                case 1:
                lblSvar.Text = "Måndag";
                break;

                case 2:
                lblSvar.Text = "Tirsdag";
                break;

                case 3:
                lblSvar.Text = "Onsdag";
                break;

                case 4:
                lblSvar.Text = "Torsdag";
                break;

                case 5:
                lblSvar.Text = "Fredag";
                break;

                case 6:
                lblSvar.Text = "Lördag";
                break;

                case 7:
                lblSvar.Text = "Söndag";
                break;

                default:
                lblSvar.Text = "Felinmatning!";
                break;
            }
        }

        private void tbxVeckodagNr_TextChanged(object sender, EventArgs e)
        {
            lblSvar.Text = "";
        }
    }
}
