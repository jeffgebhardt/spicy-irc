using System.Collections.Generic;

namespace SpicyIrc.SpicyChat.UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SpicyChatUnitTests
    {
        private SpicyChat spicyChat;

        [TestInitialize]
        public void TestInitialize()
        {
            this.spicyChat = new SpicyChat();
        }

        [TestMethod]
        public void SpicyChat_AddMessage_Tests()
        {
            this.spicyChat.AddMessage("Jeff", "Test message 1");

            Assert.AreEqual(this.spicyChat.MessagesToChatWindow.Count, 1);
            Assert.IsTrue(this.spicyChat.MessagesToChatWindow[0].Contains("Test message 1"));
        }

        [TestMethod]
        public void SpicyChat_GetAllMessages_Tests()
        {
            for (int i = 0; i < 5; i++)
            {
                this.spicyChat.AddMessage("Jeff", $"Test message {i + 1}");
            }

            List<string> allMessages = this.spicyChat.GetAllMessages();

            Assert.AreEqual(allMessages.Count, 5);
            Assert.IsTrue(this.spicyChat.MessagesToChatWindow[4].Contains("Test message 5"));
        }
    }
}
