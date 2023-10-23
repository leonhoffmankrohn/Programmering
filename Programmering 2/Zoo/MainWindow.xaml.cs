using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zoo.Klasser.Fågelklasser;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Djur> djurlista = new List<Djur>();
        DjurFabrik djurskaparn = new DjurFabrik();
        public MainWindow()
        {
            InitializeComponent();
            FörstaInititiation();
        }

        // Initieras en gång, den skapar variabler, listor, objekt och sammankopplar som vi senare använder i koden.
        void FörstaInititiation()
        {
            string[] köntyper = Enum.GetNames(typeof(KönTyp));

            foreach (string kön in köntyper)
            {
                lbxKön.Items.Add(kön);
            }

            lbxKön.SelectedIndex = 0;

            string[] djurtyper = Enum.GetNames(typeof(DjurTyp));

            foreach (string typ in djurtyper)
            {
                lbxGrupp.Items.Add(typ);
            }

            lbxGrupp.SelectedIndex = 0;
            tblSpc1.Text = "Nattaktivt?";
            lviewRegister.ItemsSource = djurlista;
        }

        // Här skickas all data om djuret och hämtas data som handlar om vilket djur och
        // skickar sedan vidare det till en klass som ger oss djuret i objekt(snacka om objektifiering)
        void SkapaDjur(string namn, double ålder, KönTyp kön, bool harExtraAttribut, string attribut2)
        {
            DjurTyp gruppval = (DjurTyp)lbxGrupp.SelectedIndex;
            Enum artval;
            if (gruppval.Equals(DjurTyp.Däggdjur))  artval = (DäggdjurTyp)lbxArt.SelectedIndex;
            else if (gruppval.Equals(DjurTyp.Fisk)) artval = (FiskTyp)lbxArt.SelectedIndex;
            else artval = (FågelTyp)lbxArt.SelectedIndex;
            djurlista.Add(djurskaparn.SkapaDjur(gruppval, artval, namn, ålder, kön, harExtraAttribut, attribut2));
        }

        // Denna metod hämtar data från formuläret samt skickar vidare den för att senare bli till ett objekt
        void HämtaDjurDataSamtSkickaVidare()
        {
            string namn = tbxNamn.Text;
            double.TryParse(tbxÅlder.Text, out double ålder);
            KönTyp könet = (KönTyp)lbxKön.SelectedIndex;
            bool harExtraAttribut = (rbJa.IsChecked == true) ? true : false;
            string attribut2 = tbxSpc2.Text;
            SkapaDjur(namn, ålder, könet, harExtraAttribut, attribut2);
        }

        // Här uppdateras listview:en med korresponderande data
        void UppdateraLviewRegister()
        {
            lviewRegister.Items.Refresh();
        }

        // Här ändrar vi vad som ska stå i spec 2
        void SättArtText()
        {
            DjurTyp gruppval = (DjurTyp)lbxGrupp.SelectedIndex;

            if (gruppval is DjurTyp.Däggdjur)
            {
                DäggdjurTyp artval = (DäggdjurTyp)lbxArt.SelectedIndex;
                tblSpc2.Text = (artval is DäggdjurTyp.Hund) ? "Ras?" : "Päls?";
            }
            else if (gruppval is DjurTyp.Fisk)
            {
                FiskTyp artval = (FiskTyp)lbxArt.SelectedIndex;
                tblSpc2.Text = (artval is FiskTyp.Lax) ? "Födelseplats?" : "Lekperiod?";
            }
            else if (gruppval is DjurTyp.Fågel)
            {
                FågelTyp artval = (FågelTyp)lbxArt.SelectedIndex;
                tblSpc2.Text = (artval is FågelTyp.Hackspett) ? "Typ?" : "Vingspann?";
            }
        }

        // Här ändrar vi vad som ska stå i spec 1 ( den som är speciell för djurgruppen ) men också fyller listbox art
        void ÄndraSpec1()
        {
            DjurTyp gruppval = (DjurTyp)lbxGrupp.SelectedIndex;

            if (gruppval is DjurTyp.Däggdjur) // Däggdjur
            {
                tblSpc1.Text = "Nattaktivt?";
                lbxArt.Items.Clear();
                string[] djurtyper = Enum.GetNames(typeof(DäggdjurTyp));
                foreach (string typ in djurtyper) { lbxArt.Items.Add(typ); }
            }
            else if (gruppval is DjurTyp.Fisk) // Fisk
            {
                tblSpc1.Text = "Sötvatten?";
                lbxArt.Items.Clear();
                string[] djurtyper = Enum.GetNames(typeof(FiskTyp));
                foreach (string typ in djurtyper) { lbxArt.Items.Add(typ); }
            }
            else if (gruppval is DjurTyp.Fågel)
            {
                tblSpc1.Text = "Flyttfågel?";
                lbxArt.Items.Clear();
                string[] djurtyper = Enum.GetNames(typeof(FågelTyp));
                foreach (string typ in djurtyper)
                {
                    lbxArt.Items.Add(typ);
                }
                lbxArt.SelectedIndex = 0;
            }
        }

        // Denna körs vid knapptryck och samlar in data om djuret och skickar data
        // för skapande och lagrande av djur men åker också vidare till att uppdatera listview:en
        private void btnLäggTillDjur_Click(object sender, RoutedEventArgs e)
        {
            HämtaDjurDataSamtSkickaVidare();
            UppdateraLviewRegister();
        }

        // Ändrar frågan som är specifik för djurgruppen
        private void lbxGrupp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ÄndraSpec1();
        }

        // Ändrar frågan som är specifik för arten
        private void lbxArt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SättArtText();
        }

        private void lviewRegister_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Djur djur = djurlista[lviewRegister.SelectedIndex];
            if (djur.Kön == KönTyp.Hona && ((djur as Fågel).ÄggPerKull != 0) || ((djur as Fisk).ÄggPerKull != 0))
            {
                btnLäggÄgg.IsEnabled = true;
            }
            else btnLäggÄgg.IsEnabled = false;
        }

        private void btnLäggÄgg_Click(object sender, RoutedEventArgs e)
        {
            Djur djur = djurlista[lviewRegister.SelectedIndex];
            if (djur is Fågel)
            {
                tblÄggVärpning.Text = (djur as Fågel).LäggÄgg();
            }
            else
            {
                tblÄggVärpning.Text = (djur as Fisk).LäggÄgg();
            }
            
        }
    }
}
