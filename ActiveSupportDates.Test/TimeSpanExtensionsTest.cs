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
    public class TimeSpanExtensionsTest
    {
        /// <summary>
        ///A test for Since
        ///</summary>
        [TestMethod()]
        public void SinceTest()
        {
            var date = DateTime.Now;
            var target = 5.Days().Since(date);
            Assert.AreEqual(date.AddDays(5), target);
        }

        /// <summary>
        ///A test for Until
        ///</summary>
        [TestMethod()]
        public void UntilTest()
        {
            var date = DateTime.Now;
            var target = 5.Days().Until(date);
            Assert.AreEqual(date.Subtract(5.Days()), target);
        }


        /// <summary>
        ///A test for And
        ///</summary>
        [TestMethod()]
        public void AndTest()
        {
            var target = 5.Days().And(2.Hours());
            Assert.AreEqual(5, target.Days);
            Assert.AreEqual(2, target.Hours);
        }

        /// <summary>
        ///A test for FromNow
        ///</summary>
        [TestMethod()]
        public void FromNowTest()
        {
            var target = 1.Year().FromNow();
            Assert.AreEqual(DateTime.Now.AddYears(1).Year, target.Year);
        }

        /// <summary>
        ///A test for Ago
        ///</summary>
        [TestMethod()]
        public void AgoTest()
        {
            var target = 1.Year().Ago();
            Assert.AreEqual(DateTime.Now.AddYears(-1).Year, target.Year);
        }

        /// <summary>
        ///A test for Before
        ///</summary>
        [TestMethod()]
        public void BeforeTest()
        {
            var target = 1.Year().Before(DateTime.Now);
            Assert.AreEqual(DateTime.Now.AddYears(-1).Year, target.Year);

        }
    }
}
