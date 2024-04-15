using System.Net;
using System.Net.Sockets;
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

namespace Övning_5._4_Klient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int port = 12345;
        TcpClient klient;
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void btnAnslut_Click(object sender, RoutedEventArgs e)
        {
            string IP = tbxIP.Text;
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(IP), port);
            klient = new TcpClient();
            btnAnslut.IsEnabled = false;
            await klient.ConnectAsync(serverEndPoint);
            btnHöger.IsEnabled = true;
            btnNer.IsEnabled = true;
            btnUpp.IsEnabled = true;
            btnVänster.IsEnabled = true;
        }

        public enum Riktning
        {
            Upp,
            Vänster,
            Höger,
            Ner,
        }

        async void Move(Riktning riktning)
        {
            byte[] message = Encoding.Unicode.GetBytes(((int)riktning).ToString());
            await klient.GetStream().WriteAsync(message);
        }

        private void btnUpp_Click(object sender, RoutedEventArgs e)
        {
            Move(Riktning.Upp);
        }

        private void btnVänster_Click(object sender, RoutedEventArgs e)
        {
            Move(Riktning.Vänster);
        }

        private void btnHöger_Click(object sender, RoutedEventArgs e)
        {
            Move(Riktning.Höger);
        }

        private void btnNer_Click(object sender, RoutedEventArgs e)
        {
            Move(Riktning.Ner);
        }

    }
}