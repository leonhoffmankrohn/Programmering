using System.Net;
using System.Net.Sockets;
using System.Text;

Console.Title = "Server";
int port = 12345;

IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, port);
TcpListener listener = new TcpListener(endpoint);

listener.Start();
TcpClient klient = listener.AcceptTcpClient();

byte[] buffer = new byte[256];
int count = klient.GetStream().Read(buffer, 0, buffer.Length);
string message = Encoding.Unicode.GetString(buffer, 0, count);

Console.WriteLine(message);

klient.Close();
listener.Stop();