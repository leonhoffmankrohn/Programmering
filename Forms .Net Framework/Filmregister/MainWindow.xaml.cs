﻿using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Filmregister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Initierar några variabler
        int index = -1;
        List<Media> mediebiblioteket = new();

        // Här rensar vi listboxen och uppdaterar med ny information
        private void UppdateraGrafik(List<Media> lista, ListBox grafiskLista) 
        {
            grafiskLista.Items.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grafiskLista.Items.Add(lista[i].ToString());
            }
        }

        // Här gör vi en ny film/serie med skriven data och sparar i en medielista(mediebiblioteket)
        private void LäggTill() 
        {
            string namn = tbxNamn.Text;
            string genre = cbxGenre.Text;
            bool film = (bool)rbnFilm.IsChecked;

            if (film && int.TryParse(tbxSpeltid.Text, out int speltid))
            {
                string filmtyp = cbxFilmtyp.Text;
                mediebiblioteket.Add(new Film(namn, genre, speltid, filmtyp));
            }
            else if (!film && int.TryParse(tbxSäsonger.Text, out int säsonger))
            {
                string serietyp = cbxSerietyp.Text;
                mediebiblioteket.Add(new Serie(namn, genre, säsonger, serietyp));
            }
            else MessageBox.Show("Använd endast siffror vid angivelse av speltid och säsonger.");

            UppdateraGrafik(mediebiblioteket, lbxRegister);
        }

        // Här tar vi bort en film från regisstret 
        private bool Tabort(List<Media> lista, ListBox grafiskLista) 
        {
            Console.WriteLine(grafiskLista.SelectedIndex);
            int index = grafiskLista.SelectedIndex;
            if (index != -1)
            {
                lista.RemoveAt(index);
                UppdateraGrafik(lista, grafiskLista);
                return true;
            }
            else
            {
                MessageBox.Show("Nja, du behöver nog välja något att ta bort först!");
                return false;
            }
        }

        private void Redigera(int index, TextBox antal, ComboBox typ)
        {
            Media medie = mediebiblioteket[index];
            tbxNamn.Text = medie.Namn;
            cbxGenre.Text = medie.Genre;
            antal.Text = medie.Antal;
        }


        private void btnRedigera_Click(object sender, RoutedEventArgs e)
        {
            index = lbxRegister.SelectedIndex;
            //filmbibliotek[index].Redigera(tbxNamn, cbxGenre, tbxÅrgång, tbxRegissör, tbxVinst);
        }

        private void rbnSerie_Click(object sender, RoutedEventArgs e)
        {
            tbxSpeltid.IsEnabled = false;
            tbxSäsonger.IsEnabled = true;
            cbxFilmtyp.IsEnabled = false;
            cbxSerietyp.IsEnabled = true;
        }

        private void rbnFilm_Click(object sender, RoutedEventArgs e)
        {
            tbxSpeltid.IsEnabled = true;
            tbxSäsonger.IsEnabled = false;
            cbxFilmtyp.IsEnabled = true;
            cbxSerietyp.IsEnabled = false;
        }
        private void btnLäggtill_Click(object sender, RoutedEventArgs e)
        {
            LäggTill();
        }

        private void btnTabort_Click(object sender, RoutedEventArgs e)
        {
            Tabort(mediebiblioteket, lbxRegister);
        }
    }
}
