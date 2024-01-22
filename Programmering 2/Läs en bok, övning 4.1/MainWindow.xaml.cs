using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace Läs_en_bok__övning_4._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string öppnadFil = "";
        OpenFileDialog dlgÖppnaFil = new OpenFileDialog();
        SaveFileDialog dlgSparaFil = new SaveFileDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void miNytt_Click(object sender, RoutedEventArgs e)
        {
            tbxText.Text = "Skriv något här";
            öppnadFil = "";
        }

        private void miÖppna_Click(object sender, RoutedEventArgs e)
        {
            if (dlgÖppnaFil.ShowDialog() == true)
            {
                dlgÖppnaFil.Filter = "Textfiler | *.txt";
                FileStream inström = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                StreamReader läsare = new StreamReader(inström);
                tbxText.Text = läsare.ReadToEnd();
                öppnadFil = dlgÖppnaFil.FileName;
                läsare.Dispose();
            }
        }

        private void miSpara_Click(object sender, RoutedEventArgs e)
        {
            if (dlgSparaFil.ShowDialog() == true)
            {
                dlgSparaFil.Filter = "Textfiler | *.txt";
                FileStream utström = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                
            }
        }

        private void miSparaSom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miStäng_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
