using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_9._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxFibonacciserien_Click(object sender, EventArgs e)
        {
            //Reset
            tbxFibonacciserien.Text = "1 ";

            //Definera nästsenaste och senaste värdet (int)
            long nya = 1;
            long senaste = 1;
            long nästSenaste = 1;

            for (int i = 0; i < 100; i++) { //Kör hundra ggr
                //addera nästsenaste och senaste värdet och skriv ut det i tbx
                tbxFibonacciserien.Text += nya.ToString() + " ";
                nya = senaste + nästSenaste;

                //nästsenaste värdet blir senaste värde
                nästSenaste = senaste;

                //senaste värdet blir nya-talet
                senaste = nya;
            }
        }
    }
}
