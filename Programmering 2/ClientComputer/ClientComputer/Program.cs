using System.Net;
using System.Net.Sockets;
using System.Text;

var ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);

UdpClient udpClient = new UdpClient();
while (true)
{
    Console.Clear();
    Console.WriteLine("Server ready for message.");
    Console.WriteLine("\nWrite something to the server: \n - ");
    string message = Console.ReadLine();
    byte[] data = Encoding.Unicode.GetBytes(message);

    udpClient.Send(data, data.Length, ipEndPoint);
}
