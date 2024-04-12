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

namespace Övning_5._3_Klient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        IPEndPoint serverEndPoint;
        TcpClient klient = new TcpClient();
        int port = 12345;

        private async void btnAnslut_Click(object sender, RoutedEventArgs e)
        {
            serverEndPoint = new IPEndPoint(IPAddress.Parse(tbxIP.Text), port);
            await klient.ConnectAsync(serverEndPoint);
            btnAnslut.IsEnabled = false; 
            btnSänd.IsEnabled = true;
        }

        private async void btnSänd_Click(object sender, RoutedEventArgs e)
        {
            if (klient.Connected)
            {
                byte[] message = Encoding.Unicode.GetBytes(tbxMessage.Text);
                await klient.GetStream().WriteAsync(message, 0, message.Length);
            }
            else Console.WriteLine("Server is not connected...");
        }
    }
}