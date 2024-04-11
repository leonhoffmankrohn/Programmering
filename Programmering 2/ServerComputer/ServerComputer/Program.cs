using System.Net;
using System.Net.Sockets;
using System.Text;

var clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
UdpClient client = new UdpClient(80);

Console.WriteLine("Server redo för meddelanden.\n");
while (true)
{
    byte[] indata = client.Receive(ref clientEndPoint);
    Console.WriteLine(" - " + Encoding.Unicode.GetString(indata));
}