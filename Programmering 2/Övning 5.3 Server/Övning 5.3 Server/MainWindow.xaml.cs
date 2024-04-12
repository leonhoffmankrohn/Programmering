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

namespace Övning_5._3_Server
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpListener listener = new TcpListener(IPAddress.Any, 12345);
        public MainWindow()
        {
            InitializeComponent();
            Connect();
        }

        async void Connect()
        {
            listener.Start();
            TcpClient klient = await listener.AcceptTcpClientAsync();
            GetMessages(klient);

        }

        async void GetMessages(TcpClient k)
        {
            while (true)
            {
                byte[] buffer = new byte[1024];
                try
                {
                    int n = await k.GetStream().ReadAsync(buffer, 0, buffer.Length);
                    tblInkorg.Text += Encoding.Unicode.GetString(buffer, 0, n);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}