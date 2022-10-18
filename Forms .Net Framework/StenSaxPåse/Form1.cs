using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StenSaxPåse
{
    public partial class Form1 : Form
    {
        int nrDatorVinster;
        int nrSpelarVinster;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpela_Click(object sender, EventArgs e)
        {
            gbxStenSaxPåse.Enabled = true;
            btnSpela.Enabled = false;
            lblDatornsVal.Text = "";
            lblResultat.Text = "";
            nrSpelarVinster = 0;
            nrDatorVinster = 0;
        }

        private void pbxSten_Click(object sender, EventArgs e)
        {
            Random slump = new Random();
            int datornsTal = slump.Next(1,4);
            string datornsVal = "";
            switch (datornsTal) 
            {
                case 1:
                    datornsVal = "Sten";
                    break;
                case 2:
                    datornsVal = "Sax";
                    break;
                case 3:
                    datornsVal = "Påse";
                    break;
            }
            lblDatornsVal.Text = datornsVal;

            if (datornsVal.Equals("Sax"))
            {
                nrSpelarVinster++;
            }
            else if (datornsVal.Equals("Påse"))
            {
                nrDatorVinster++;
            }

            lblResultat.Text = "Dator: " + nrDatorVinster +
                               "  Spelare: " + nrSpelarVinster;

            if (nrDatorVinster > 2 || nrSpelarVinster > 2) 
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Dator: " + nrDatorVinster +
                                           "  Spelare: " + nrSpelarVinster + "\r\n");
            }
        }

        private void pbxSax_Click(object sender, EventArgs e)
        {
            Random slump = new Random();
            int datornsTal = slump.Next(1, 4);
            string datornsVal = "";
            switch (datornsTal)
            {
                case 1:
                    datornsVal = "Sten";
                    break;
                case 2:
                    datornsVal = "Sax";
                    break;
                case 3:
                    datornsVal = "Påse";
                    break;
            }
            lblDatornsVal.Text = datornsVal;

            if (datornsVal.Equals("Påse"))
            {
                nrSpelarVinster++;
            }
            else if (datornsVal.Equals("Sten"))
            {
                nrDatorVinster++;
            }

            lblResultat.Text = "Dator: " + nrDatorVinster +
                               "  Spelare: " + nrSpelarVinster;

            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Dator: " + nrDatorVinster +
                                           "  Spelare: " + nrSpelarVinster + "\r\n");
            }
        }

        private void pbxPåse_Click(object sender, EventArgs e)
        {
            Random slump = new Random();
            int datornsTal = slump.Next(1, 4);
            string datornsVal = "";
            switch (datornsTal)
            {
                case 1:
                    datornsVal = "Sten";
                    break;
                case 2:
                    datornsVal = "Sax";
                    break;
                case 3:
                    datornsVal = "Påse";
                    break;
            }
            lblDatornsVal.Text = datornsVal;

            if (datornsVal.Equals("Sten"))
            {
                nrSpelarVinster++;
            }
            else if (datornsVal.Equals("Sax"))
            {
                nrDatorVinster++;
            }

            lblResultat.Text = "Dator: " + nrDatorVinster +
                               "  Spelare: " + nrSpelarVinster;

            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("Dator: " + nrDatorVinster +
                                           "  Spelare: " + nrSpelarVinster + "\r\n");
            }
        }
    }
}
