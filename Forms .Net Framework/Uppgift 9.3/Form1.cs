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
            //Definera antal längd(mm) och papperstjocklek(mm) och antal ggr vikt:
            long antalKilometer = 384000000000;
            double tjocklek = 0.1;
            int antalVik = 0;

            //Whileloop som räknar antal ggr vikt 384000000000 = 0.1 * 2^x
            while (tjocklek < antalKilometer) 
            {
                tjocklek *= 2;
                antalVik++;
            }

            //Skriv resultat
            lblResultat.Text = "Du måste vika den: "+ antalVik +" gånger då.";
        }
    }
}
