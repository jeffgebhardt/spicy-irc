using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpicyIrc.SpicyChat;

namespace SpicyIrc.SpicyClient
{
    public partial class SpicyClient : Form
    {
        public SpicyChat.SpicyChat SpicyChat;

        public SpicyClient()
        {
            InitializeComponent();

            this.SpicyChat = new SpicyChat.SpicyChat();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            SpicyChat.AddMessage("Jeff", sendTxtBox.Text);
            sendTxtBox.Text = "";
        }

        private void displayMessages(IEnumerable<string> messages)
        {
            foreach (var message in messages)
            {
               displayMessagesTxtBox.AppendText(message); 
            }
        }
    }
}
