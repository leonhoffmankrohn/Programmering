using System;
using System.Collections.Generic;
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

namespace Zoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Djur> djurlista = new List<Djur>();
        public MainWindow()
        {
            InitializeComponent();
            string[] köntyper = Enum.GetNames(typeof(KönTyp));

            foreach (string kön in köntyper) lbxKön.Items.Add(kön);
        }
        void UppdateraLviewRegister()
        {

        }

        void SkapaDjur(string namn, double ålder, KönTyp kön)
        {
            Djur djur = new() { namn, ålder, kön };
        }

        private void btnLäggTillDjur_Click(object sender, RoutedEventArgs e)
        {
            string namn = tbxNamn.Text;
            double.TryParse(tbxÅlder.Text, out double ålder);
            
        }
    }
}
