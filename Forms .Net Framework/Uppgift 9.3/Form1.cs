using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxAntal_TextChanged(object sender, EventArgs e)
        {
            lblResultat.Text = "Du måste vika den: xxxxx gånger då.";
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            //Definera en antalVik variabel (int)
            //Hämta värden
            int kilometer = int.Parse(tbxAntal.Text);
            for (int i = kilometer*1000; i > 0.01; i /= 2) { 
                
            }
        }
    }
}
