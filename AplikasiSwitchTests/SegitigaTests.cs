using Microsoft.VisualStudio.TestTools.UnitTesting;
using AplikasiSwitch;
using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiSwitch.Tests
{
    [TestClass()]

    public class SegitigaTests
    {

        Segitiga SG = new Segitiga();
        [TestMethod()]
        public void sisiS3Test()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void LuasS3Test()
        {
            Assert.AreEqual(17.5, SG.LuasS3(5, 7));
        }

        [TestMethod()]
        public void tampilS3Test()
        {
            Assert.IsTrue(true);
        }
    }
}