namespace SpicyIrc.SpicyChat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Serialization;
    using SpicyUser;

    [DataContract]
    public class SpicyChat
    {
        [DataMember]
        public List<string> MessagesToChatWindow = new List<string>();

        public void AddMessage(string userName, string message)
        {
            var currentTime = DateTime.Now;
            this.MessagesToChatWindow.Add($"{currentTime:HH:mm:ss} - {userName}: {message}");
        }

        public IEnumerable<string> GetAllMessages()
        {
            return this.MessagesToChatWindow;
        }
    }
}
