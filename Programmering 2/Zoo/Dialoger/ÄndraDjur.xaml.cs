using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Zoo.Klasser.Fågelklasser;

namespace Zoo.Dialoger
{
    /// <summary>
    /// Interaction logic for ÄndraDjur.xaml
    /// </summary>
    public partial class ÄndraDjur : Window
    {
        Djur djur; // djur att ändra
        internal ÄndraDjur(Djur _djurAttÄndra)
        {
            djur = _djurAttÄndra;
            InitializeComponent();
            Initition();
        }
        internal void Initition()
        {
            tbxNamn.Text = djur.Namn;
            tbxÅlder.Text = djur.Ålder.ToString();

            string[] köntyper = Enum.GetNames(typeof(KönTyp));
            foreach (string kön in köntyper)
            {
                lbxKön.Items.Add(kön);
            }
            lbxKön.SelectedIndex = (int)djur.Kön;
            SättSpec1o2();
        }

        internal void SättSpec1o2()
        {
            if (djur is Däggdjur) // Däggdjur
            {
                tblSpc1.Text = "Nattaktivt?";
                if ((djur as Däggdjur).Nattaktiv) { rbJa.IsChecked = true; }
                else { rbNej.IsChecked = true; }

                if (djur is Hund) 
                { 
                    tbxSpc2.Text = (djur as Hund).Ras;
                    tblSpc2.Text = "Ras?";
                }
                else
                {
                    tbxSpc2.Text = (djur as Katt).Päls;
                    tblSpc2.Text = "Päls?";
                }
            }
            else if (djur is Fisk) // Fisk
            {
                tblSpc1.Text = "Sötvatten?";
                if ((djur as Fisk).Sötvatten) { rbJa.IsChecked = true; }
                else { rbNej.IsChecked= true; }

                if (djur is Lax)
                {
                    tbxSpc2.Text = (djur as Lax).Födselplats;
                    tblSpc2.Text = "Födselplats";
                }
                else
                {
                    tbxSpc2.Text = (djur as Sill).Lekperiod;
                    tblSpc2.Text = "Lekperiod";
                }
            }
            else // Fågel
            {
                tblSpc1.Text = "Flyttfågel?";
                if ((djur as Fågel).Flyttfågel) { rbJa.IsChecked = true; }
                else { rbNej.IsChecked = true; }

                if (djur is Falk)
                {
                    tbxSpc2.Text = (djur as Falk).Vingspann.ToString();
                    tblSpc2.Text = "Vingspann";
                }
                else
                {
                    tbxSpc2.Text = (djur as Hackspett).Typ;
                    tblSpc2.Text = "Typ";
                }
            }
        }
        internal Djur SkapaDjur()
        {
            // gruppval, artval, namn, ålder, kön, harExtraAttribut, attribut2
            DjurTyp gruppval;
            Enum artval;
            if (djur is Däggdjur) // Däggdjur
            {
                gruppval = DjurTyp.Däggdjur;
                artval = (djur is Hund) ? DäggdjurTyp.Hund : DäggdjurTyp.Katt;
            }
            else if (djur is Fisk) // Fisk
            {
                gruppval = DjurTyp.Fisk;
                artval = (djur is Lax) ? FiskTyp.Lax : FiskTyp.Sill;
            }
            else // Fågel
            {
                gruppval = DjurTyp.Fågel;
                artval = (djur is Falk) ? FågelTyp.Falk : FågelTyp.Hackspett;
            }

            string namn = tbxNamn.Text;
            double.TryParse(tbxÅlder.Text, out double ålder);
            KönTyp könet = (KönTyp)lbxKön.SelectedIndex;
            bool harExtraAttribut = (rbJa.IsChecked == true) ? true : false;
            string attribut2 = tbxSpc2.Text;

            DjurFabrik djurskaparn = new DjurFabrik();
            Djur nyttDjur = djurskaparn.SkapaDjur(gruppval, artval, namn, ålder, könet, harExtraAttribut, attribut2);
            nyttDjur.Id = djur.Id;
            return nyttDjur;
        }

        private void btnÄndraDjur_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
