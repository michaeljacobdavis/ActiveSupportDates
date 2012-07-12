using ActiveSupportDates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ActiveSupportDates.Test
{


    /// <summary>
    ///This is a test class for ModifiersTest and is intended
    ///to contain all ModifiersTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NumericExtensionsTest
    {
        [TestMethod()]
        public void SecondsTest()
        {
            var target = 5.Seconds();
            Assert.AreEqual(5, target.Seconds);

            target = 1.Second();
            Assert.AreEqual(1, target.Seconds);

            target = 1.5.Seconds();
            Assert.AreEqual(1, target.Seconds);
            Assert.AreEqual(500, target.Milliseconds);
        }

        [TestMethod()]
        public void Minutes()
        {
            var target = 5.Minutes();
            Assert.AreEqual(5, target.Minutes);
            
            target = 1.Minute();
            Assert.AreEqual(1, target.Minutes);

            target = 1.5.Minutes();
            Assert.AreEqual(1, target.Minutes);
            Assert.AreEqual(30, target.Seconds);
        }

        [TestMethod()]
        public void Hours()
        {
            var target = 5.Hours();
            Assert.AreEqual(5, target.Hours);

            target = 1.Hour();
            Assert.AreEqual(1, target.Hours);

            target = 1.5.Hours();
            Assert.AreEqual(1, target.Hours);
            Assert.AreEqual(30, target.Minutes);
        }

        [TestMethod()]
        public void Days()
        {
            var target = 5.Days();
            Assert.AreEqual(5, target.Days);

            target = 1.Day();
            Assert.AreEqual(1, target.Days);

            target = 1.5.Days();
            Assert.AreEqual(1, target.Days);
            Assert.AreEqual(12, target.Hours);
        }

        [TestMethod()]
        public void Weeks()
        {
            var target = 1.Week();
            Assert.AreEqual(7, target.Days);

            target = 2.Weeks();
            Assert.AreEqual(14, target.Days);

            target = 1.5.Weeks();
            Assert.AreEqual(10, target.Days);
            Assert.AreEqual(12, target.Hours);
        }

        [TestMethod()]
        public void Months()
        {
            var target = 1.Month();
            Assert.AreEqual(30, target.Days);

            target = 2.Months();
            Assert.AreEqual(60, target.Days);

            target = 1.5.Months();
            Assert.AreEqual(45, target.Days);
        }

        [TestMethod()]
        public void Years()
        {
            var target = 1.Year();
            Assert.AreEqual(365, target.Days);
            Assert.AreEqual(6, target.Hours);

            target = 2.Year();
            Assert.AreEqual(365*2, target.Days);
            Assert.AreEqual(6*2, target.Hours);

            target = 1.5.Years();
            Assert.AreEqual(547, target.Days);
            Assert.AreEqual(21, target.Hours);
        }
    }
}
