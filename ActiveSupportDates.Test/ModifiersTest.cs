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
    public class ModifiersTest
    {

        [TestMethod()]
        public void AgoTest()
        {
            
        }

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
    }
}
