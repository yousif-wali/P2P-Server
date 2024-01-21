using System;
using System.Net.Sockets;
using System.Text;

class Client
{
    public static void StartClient()
    {
        try
        {
            Int32 port = 13000;
            TcpClient client = new TcpClient("127.0.0.1", port);

            String message = "Hello, Server!";
            Byte[] data = Encoding.ASCII.GetBytes(message);

            NetworkStream stream = client.GetStream();

            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent: {0}", message);

            stream.Close();
            client.Close();
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("ArgumentNullException: {0}", e);
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }
    }
}
