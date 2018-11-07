namespace SpicyIrc.SpicyClient
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using SpicyIrc.SpicyChat; 

    public partial class Client : Form
    {
        public NetworkCommands NetworkCommands;

        public Client()
        {
            InitializeComponent();

            this.NetworkCommands = new NetworkCommands();           
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            this.NetworkCommands.Send(sendTxtBox.Text);
            sendTxtBox.Clear();
        }
        private void connectBtn_Click(object sender, EventArgs e)
        {
            string serverName = "irc.freenode.net" ?? ircServerNameTxtBox.Text;
            string serverPortNumber = "6667" ?? ircServerPortNumberTxtBox.Text;
            int serverPortNumberParsed = Int16.Parse(serverPortNumber);

            this.NetworkCommands.ConnectToServer(serverName, serverPortNumberParsed);
        }

        public void DisplayMessage(string message)
        {
            displayMessagesTxtBox.AppendText(message + Environment.NewLine);
        }
    }
}
