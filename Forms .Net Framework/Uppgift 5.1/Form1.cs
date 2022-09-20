using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            lblSvar.Text = "SVAR: ";
            double svar = double.Parse(tbxTal.Text);
            double tal = svar;

            // string svar = ((2*(tal+1)-6)/2+3-tal).ToString();
            svar++;
            svar *= 2;
            svar -= 6;
            svar /= 2;
            svar += 3;
            svar -= tal;
            lblSvar.Text += svar.ToString();
            /*
            lblAdd1.Text = (++svar).ToString();
            lblMult2.Text = (svar*2).ToString();
            lblSub6.Text = (svar*2-6).ToString();
            lblDiv2.Text = ((svar*2-6)/2).ToString();
            svar = double.Parse(lblDiv2.Text); //Mellanresultat
            lblAdd3.Text = (svar+3).ToString();
            lblSubTal.Text = (svar-tal+3).ToString();
            lblSvar.Text += lblSubTal.Text;
            */

        }
    }
}
