namespace SpicyIrc.SpicyChat
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Chat
    {
        [DataMember]
        public List<string> MessagesToChatWindow = new List<string>();

        public void AddMessage(string userName, string message)
        {
            var currentTime = DateTime.Now;
            this.MessagesToChatWindow.Add($"{currentTime:HH:mm:ss} - {userName}: {message}");
        }

        public List<string> GetAllMessages()
        {
            return this.MessagesToChatWindow;
        }
    }
}
