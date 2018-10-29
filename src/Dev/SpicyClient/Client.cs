namespace SpicyIrc.SpicyClient
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using SpicyIrc.SpicyChat; 

    public partial class Client : Form
    {
        public Chat Chat;
        public NetworkCommands NetworkCommands;

        public Client()
        {
            InitializeComponent();

            this.Chat = new Chat();
            this.NetworkCommands = new NetworkCommands();
            
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            displayMessagesTxtBox.Clear();

            Chat.AddMessage("Jeff", sendTxtBox.Text);
            sendTxtBox.Clear();

            List<string> allMessages = Chat.GetAllMessages();

            DisplayMessages();
        }

        private void DisplayMessages()
        {
            foreach (var message in Chat.MessagesToChatWindow)
            {
               displayMessagesTxtBox.AppendText(message + Environment.NewLine);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            NetworkCommands.ConnectToServer();
        }
    }
}
