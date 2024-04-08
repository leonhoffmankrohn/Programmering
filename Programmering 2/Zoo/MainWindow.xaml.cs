using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Zoo.Dialoger;
using Zoo.Interfaces;
using Zoo.Klasser.Fågelklasser;
using ListManager;
using Microsoft.Win32;
using System.IO;
using Zoo.Klasser;
using UtilitiesLib;

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Djurlista djurlista = new Djurlista();
        DjurFabrik djurskaparn = new DjurFabrik();
        string filnamn = "";

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
            lviewRegister.ItemsSource = djurlista.HämtaKopia();
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
            lviewRegister.ItemsSource = djurlista.HämtaKopia();
            //lviewRegister.Items.Refresh();
            CollectionView vy = (CollectionView)CollectionViewSource.GetDefaultView(lviewRegister.ItemsSource);
            vy.SortDescriptions.Add(new SortDescription("Namn", ListSortDirection.Ascending));
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

        // Här ändrar vi vad som ska stå i spec 2
        void ÄndraSpec2()
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

        // Kollar om djuret kan värpa och aktiverar knappen som kan räkna ut hurm ånga ägg som värps.
        private void KollaOmVärpning()
        {
            if (lviewRegister.SelectedIndex > -1)
            {
                Djur djur = djurlista.GetAt(djurlista.IndexOfDjur((Djur)lviewRegister.SelectedItem));
                if (djur.Kön == KönTyp.Hona && (djur is ILäggÄgg))
                {
                    btnLäggÄgg.IsEnabled = true;
                }
            }
            else btnLäggÄgg.IsEnabled = false;
        }

        // Skriver ut hur många ägg djuret värper
        private void AntalÄggVärpa()
        {
            Djur djur = (Djur)lviewRegister.SelectedItem;
            if (djur is Fågel)
            {
                tblÄggVärpning.Text = (djur as Fågel).LäggÄgg();
            }
            else
            {
                tblÄggVärpning.Text = (djur as Fisk).LäggÄgg();
            }
        }

        // Tar bort selekterade djuret
        private void TaBortDjur()
        {
            if (lviewRegister.SelectedIndex > -1)
            {
                Djur djur = (Djur)lviewRegister.Items[lviewRegister.SelectedIndex];
                djurlista.Delete(djurlista.IndexOfDjur(djur));
                UppdateraLviewRegister();
            }
        }

        // Ploppar upp en dialogruta som man får ändra vissa egenskaper på valt djur, sedan sparas dessa på samma ID
        private void ÄndraDjurlista()
        {
            if (lviewRegister.SelectedIndex > -1)
            {
                Djur djur = (Djur)lviewRegister.SelectedItem;
                ÄndraDjur dialog = new ÄndraDjur(djur);
                bool ändra = (bool)dialog.ShowDialog();


                if (ändra)
                {
                    Djur nyttdjur = dialog.SkapaDjur();
                    int index = djurlista.IndexOfDjur(djur);
                    djurlista.ChangeAt(nyttdjur, index);
                    UppdateraLviewRegister();
                }
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
            ÄndraSpec2();
        }

        // Kollar om vald är hona och kan värpa, då 
        private void lviewRegister_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KollaOmVärpning();
            btnÄndraLview.IsEnabled = true;
            btnTaBortLview.IsEnabled = true;
        }

        // Kan bara köras om djuret är fågel eller fisk och skriver ut hur många ägg den värper bredvid knappen
        private void btnLäggÄgg_Click(object sender, RoutedEventArgs e)
        {
            AntalÄggVärpa();
        }

        // Hänvisar till tabort djur metoden
        private void btnTaBortLview_Click(object sender, RoutedEventArgs e)
        {
            TaBortDjur();
        }

        // Hänvisar till ändradjur metoden
        private void btnÄndraLview_Click(object sender, RoutedEventArgs e)
        {
            ÄndraDjurlista();
        }

        private void skapaNy_Click(object sender, RoutedEventArgs e)
        {
            filnamn = "";
            djurlista = new Djurlista();
            UppdateraLviewRegister();
        }

        private void öppnaFil_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlgÖppnaFil = new OpenFileDialog() { DefaultExt = ".json", Filter = "Json filer | *.json" };
            if (dlgÖppnaFil.ShowDialog() == true)
            {
                try
                {
                    filnamn = dlgÖppnaFil.FileName;

                    Serializer<SparObjekt> serializer = new Serializer<SparObjekt>();
                    SparObjekt obj = serializer.Deserialize(filnamn);
                    djurlista.Hämtalista(obj); 
                    UppdateraLviewRegister();
                }
                catch { }
            }
        }

        private void sparaFil_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlgSparaFil = new SaveFileDialog() { DefaultExt = ".json", Filter = "Json filer | *.json" };
            dlgSparaFil.FileName = filnamn;
            if (dlgSparaFil.ShowDialog() == true)
            {
                try
                {
                    Serializer<SparObjekt> serializer = new Serializer<SparObjekt>();
                    serializer.Serialize(djurlista.SparaLista(), (dlgSparaFil.FileName == "") ? "Djurdata" : dlgSparaFil.FileName);
                }
                catch { }
            }
        }

        private void Stäng_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
