using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VillSeListan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<String> lista = new List<string>();

        private void btnLäggTill_Click(object sender, EventArgs e)
        {
            string serie = tbxSerie.Text;
            if (serie.Trim(' ') != "") {
                lista.Add(serie);
                lblVisa.Text = serie;
            }
            else lblVisa.Text = "Du måste skriva något";
        }

        private void btnVisa_Click(object sender, EventArgs e)
        {
            bool lyckat = int.TryParse(tbxVisa.Text, out int index);
            if (lyckat && (0 <= index && index < lista.Count)) lblVisa.Text = lista[index];
            else lblVisa.Text = "Felinmatning";
        }
    }
}
