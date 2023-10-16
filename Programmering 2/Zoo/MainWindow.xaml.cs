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

            // Här läggs värden in som ska vara från början
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

        // Här uppdateras listview:en med korresponderande data
        void UppdateraLviewRegister()
        {
            lviewRegister.Items.Refresh();
        }

        // Här skapas ett djur och läggs till i en djurlista
        void SkapaDjur(string namn, double ålder, KönTyp kön, bool harExtraAttribut, string attribut2)
        {
            DjurTyp gruppval = (DjurTyp)lbxGrupp.SelectedIndex;
            Enum artval = (gruppval.Equals(DjurTyp.Däggdjur)) ? (DäggdjurTyp)lbxArt.SelectedIndex : (FiskTyp)lbxArt.SelectedIndex;
            djurlista.Add(djurskaparn.SkapaDjur(gruppval, artval, namn, ålder, kön, harExtraAttribut, attribut2));
        }

        // Denna körs vid knapptryck och samlar in data om djuret och skickar data för skapande och lagrande av djur men åker också vidare till att uppdatera listview:en
        private void btnLäggTillDjur_Click(object sender, RoutedEventArgs e)
        {
            string namn = tbxNamn.Text;
            double.TryParse(tbxÅlder.Text, out double ålder);
            KönTyp könet = (KönTyp)lbxKön.SelectedIndex;
            bool harExtraAttribut = (rbJa.IsChecked == true) ? true : false;
            string attribut2 = tbxSpc2.Text;
            SkapaDjur(namn, ålder, könet, harExtraAttribut, attribut2);
            UppdateraLviewRegister();
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
                tblSpc2.Text = (artval is FiskTyp.Lax) ? "Nattaktivt?" : "Sötvatten?";
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
            lbxArt.SelectedIndex = 0;
        }

        // Här ändrar vi frågan i textblocket ifall däggdjur eller fisk är vald i listboxen
        private void lbxGrupp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ÄndraSpec1();
        }

        // Ändrar frågan för arten
        private void lbxArt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SättArtText();
        }
    }
}
