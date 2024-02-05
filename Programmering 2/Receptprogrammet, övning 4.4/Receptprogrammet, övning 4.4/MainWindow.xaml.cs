using Microsoft.Win32;
using System.IO;
using System.Text;
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

namespace Receptprogrammet__övning_4._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ingridiens> ingridienser = new List<Ingridiens>();
        string öppnadFil = "";
        OpenFileDialog dlgÖppnaFil = new OpenFileDialog();
        SaveFileDialog dlgSparaFil = new SaveFileDialog();

        public MainWindow()
        {
            InitializeComponent();
        }

        void UppdateraDg()
        {
            dgRecept.ItemsSource = null;
            dgRecept.ItemsSource = ingridienser;
        }

        void TömInput()
        {
            tbxNamn.Clear();
            tbxMängd.Clear();
            tbxMått.Clear();
        }

        bool Tomhet(TextBox tbx)
        {
            return (tbx.Text == "") ? true : false;
        }

        void LäggTill()
        {
            if (!(Tomhet(tbxNamn) && Tomhet(tbxMängd) && Tomhet(tbxMått)))
            {
                int.TryParse(tbxMängd.Text, out int mängd);
                ingridienser.Add(new Ingridiens(tbxNamn.Text, mängd, tbxMått.Text));
                TömInput();
                UppdateraDg();
            }
        }

        private void btnLäggTill_Click(object sender, RoutedEventArgs e)
        {
            LäggTill();
        }

        private void miÖppna_Click(object sender, RoutedEventArgs e)
        {
            ingridienser = new List<Ingridiens>();
            if (dlgÖppnaFil.ShowDialog() == true)
            {
                dlgÖppnaFil.Filter = "Textfiler | *.txt";
                FileStream inström = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader läsare = new BinaryReader(inström);
                öppnadFil = dlgÖppnaFil.FileName;

                string hämtadeIngridienser = läsare.ReadString();
                while (hämtadeIngridienser != null || hämtadeIngridienser != "")
                {
                    string[] strings = hämtadeIngridienser.Split(' ');
                    int.TryParse(strings[1], out int mängd);
                    ingridienser.Add(new Ingridiens(strings[0], mängd, strings[2]));
                    hämtadeIngridienser = läsare.ReadString();
                }
                läsare.Dispose();
            }
        }

        private void miSparaSom_Click(object sender, RoutedEventArgs e)
        {
            if (dlgSparaFil.ShowDialog() == true)
            {
                dlgSparaFil.Filter = "Textfiler | *.txt";
                FileStream utström = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter skrivare = new BinaryWriter(utström);
                foreach (Ingridiens ingridiens in ingridienser)
                {
                    skrivare.Write(ingridiens.ToString());
                }
                skrivare.Dispose();
            }
        }
    }
}