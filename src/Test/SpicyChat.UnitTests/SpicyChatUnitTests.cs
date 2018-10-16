namespace SpicyIrc.SpicyChat.UnitTests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SpicyChatUnitTests
    {
        private Chat chat;

        [TestInitialize]
        public void TestInitialize()
        {
            this.chat = new Chat();
        }

        [TestMethod]
        public void SpicyChat_AddMessage_Tests()
        {
            this.chat.AddMessage("Jeff", "Test message 1");

            Assert.AreEqual(this.chat.MessagesToChatWindow.Count, 1);
            Assert.IsTrue(this.chat.MessagesToChatWindow[0].Contains("Test message 1"));
        }

        [TestMethod]
        public void SpicyChat_GetAllMessages_Tests()
        {
            for (int i = 0; i < 5; i++)
            {
                this.chat.AddMessage("Jeff", $"Test message {i + 1}");
            }

            List<string> allMessages = this.chat.GetAllMessages();

            Assert.AreEqual(allMessages.Count, 5);
            Assert.IsTrue(this.chat.MessagesToChatWindow[4].Contains("Test message 5"));
        }
    }
}
