using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWolrdTests.Fake;

namespace HelloWorld.Tests
{
    [TestClass()]
    public class MessageTests
    {
        [TestMethod()]
        public void MessageTest_matin()
        {
            FakeTime fake = new FakeTime(new DateTime(2018, 08, 21, 11, 00, 00));

            Message message = new Message(fake);
            string result = message.PropertyMDate;
            Assert.IsTrue(result.Contains("Bonjour"));
        }

        [TestMethod()]
        public void MessageTest_aprem()
        {
            FakeTime fake = new FakeTime(new DateTime(2018, 08, 21, 14, 10, 00));

            Message message = new Message(fake);
            string result = message.PropertyMDate;
            Assert.IsTrue(result.Contains("Bon après-midi"));
        }
        [TestMethod()]
        public void MessageTest_soir()
        {
            FakeTime fake = new FakeTime(new DateTime(2018, 08, 21, 19, 25, 00));

            Message message = new Message(fake);
            string result = message.PropertyMDate;
            Assert.IsTrue(result.Contains("Bonsoir"));
        }
        [TestMethod()]
        public void MessageTest_weekend()
        {
            FakeTime fake = new FakeTime(new DateTime(2018, 08, 19, 21, 45, 00));

            Message message = new Message(fake);
            string result = message.PropertyMDate;
            Assert.IsTrue(result.Contains("tu es en week"));
        }
    }
}