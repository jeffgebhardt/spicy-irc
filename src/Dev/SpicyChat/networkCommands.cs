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
        private string _inputLine;

        private Stream _stream;

        private StreamReader _reader;

        private StreamWriter _writer;

        public void ConnectToServer(string server, int port)
        {
            try
            {
                TcpClient tcpClient = new TcpClient(server, port);

                _stream = tcpClient.GetStream();
                _reader = new StreamReader(_stream);
                _writer = new StreamWriter(_stream);
                
                Listen();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void Listen()
        {
            while ((_inputLine = _reader.ReadLine()) != null)
            {
                Console.WriteLine(_inputLine);
            }
        }

        public void Send(string message)
        {
            _writer.WriteLine(message);
            _writer.Flush();
        }

        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }

        public void SetNickName()
        {
            throw new NotImplementedException();
        }

        public void JoinChannel()
        {
            throw new NotImplementedException();
        }
    }
}
