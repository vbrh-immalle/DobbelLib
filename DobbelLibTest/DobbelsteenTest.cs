using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DobbelLib;

namespace DobbelLibTest
{
    [TestClass]
    public class DobbelsteenTest
    {
        [TestMethod]
        public void TestDobbelsteenWaardeNaConstructie()
        {
            var d = new Dobbelsteen();

            Assert.AreEqual(0, d.Waarde);
        }

        [TestMethod]
        public void TestDobbelsteenWaardeNaWorp()
        {
            var d = new Dobbelsteen();

            for(var i=0; i<20; i++)
            {
                d.Werp();
                Assert.IsTrue(d.Waarde > 0 && d.Waarde < 7);
            }
        }
    }
}
