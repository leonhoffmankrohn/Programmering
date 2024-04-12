using System.Net;
using System.Net.Sockets;
using System.Text;

Console.Title = "Klient";

IPEndPoint serverpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
TcpClient client = new();

client.Connect(serverpoint);

Console.WriteLine("Connected:");
string message = Console.ReadLine();

byte[] bytes = Encoding.Unicode.GetBytes(message);

client.GetStream().Write(bytes, 0, bytes.Length);
client.Close();