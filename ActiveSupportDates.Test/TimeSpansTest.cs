using ActiveSupportDates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ActiveSupportDates.Test
{
    
    
    /// <summary>
    ///This is a test class for TimeSpansTest and is intended
    ///to contain all TimeSpansTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TimeSpansTest
    {
        [TestMethod()]
        public void SecondsTest()
        {
            var target = 5.Seconds();
            Assert.AreEqual(5, target.Seconds);
        }

        [TestMethod()]
        public void Minutes()
        {
            var target = 5.Minutes();
            Assert.AreEqual(5, target.Minutes);
        }

        [TestMethod()]
        public void Hours()
        {
            var target = 5.Hours();
            Assert.AreEqual(5, target.Hours);
        }

        [TestMethod()]
        public void Days()
        {
            var target = 5.Days();
            Assert.AreEqual(5, target.Days);
        }

        [TestMethod()]
        public void Weeks()
        {
            var target = 1.Week();
            Assert.AreEqual(7, target.Days);
        }

        [TestMethod()]
        public void Months()
        {
            var target = 1.Month();
            Assert.AreEqual(30, target.Days);
        }

        [TestMethod()]
        public void Years()
        {
            var target = 1.Year();
            Assert.AreEqual(365, target.Days);
        }

    }
}
