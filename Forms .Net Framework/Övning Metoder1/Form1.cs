using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_Metoder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tal1;
        int tal2;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tal1 = int.Parse(tbxTal1.Text);
            tal2 = int.Parse(tbxTal2.Text);

            Addition();
        }

        void Addition() {
            int summa = tal1 + tal2;
            lblResultat.Text = "Resultat: " + summa;
        }

    }
}
