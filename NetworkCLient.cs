using System.Net.Sockets;
using System.Text;

public class NetworkClient
{
    private TcpClient client;
    private NetworkStream stream;

    public void Connect(string hostname, int port)
    {
        client = new TcpClient(hostname, port);
        stream = client.GetStream();
    }

    public void SendData(string data)
    {
        byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes(data);
        stream.Write(bytesToSend, 0, bytesToSend.Length);
    }

    // Include methods for receiving data and handling disconnections
}
