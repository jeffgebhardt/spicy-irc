namespace SpicyIrc.SpicyChat
{
    using System;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Net.Sockets;
    using System.Threading;

    public class NetworkCommands
    {
        public void ConnectToServer()
        {
            NetworkStream stream;
            StreamReader reader;

            try
            {
                TcpClient tcpClient = new TcpClient("irc.freenode.net", 6667);

                stream = tcpClient.GetStream();
                reader = new StreamReader(stream);              

                reader.Close();
                tcpClient.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
