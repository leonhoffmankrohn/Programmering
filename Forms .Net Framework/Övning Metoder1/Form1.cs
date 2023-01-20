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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(tbxTal1.Text);
            int tal2 = int.Parse(tbxTal2.Text);

            lblResultat.Text = "Resultat: " + Addition(tal1, tal2);
        }

        int Addition(int tal1, int tal2) {
            int summa = tal1 + tal2;
            return summa;
        }

    }
}
