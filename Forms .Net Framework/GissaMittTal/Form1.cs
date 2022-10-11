using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GissaMittTal
{
    public partial class Form1 : Form
    {
        int datornsTal;
        int antalGissningar;
        public Form1()
        {
            InitializeComponent();

            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst+1);

            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            lblDatornsTal.Text = "??";
            antalGissningar = 0;
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datornsTal)
            {
                lblMinaResultat.Text = "Korrekt efter " + antalGissningar + " försök.";
                gbxSpelet.Enabled = false;
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + " försök\r\n");
            }
            else if (gissatTal < datornsTal)
            {
                lblResultat.Text = "För lågt. Försök igen.";
            }
            else
            {
                lblResultat.Text = "För högt. Försök igen.";
            }
        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            gbxSpelet.Enabled = true;
            btnSpelaIgen.Enabled = false;
            antalGissningar = 0;
            tbxGissa.Text = "";
            lblResultat.Text = "";
            lblDatornsTal.Text = "??";
        }
    }
}
