using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExtentionMethods;
using TP5_UI;

namespace UnitTest
{
    [TestClass]
    public class UnitTestExtentionMethods
    {
        [TestMethod]
        public void TestMethod1()
        {
            int numero = 4;
            bool esperado = true;

            bool actual = numero.MenorQueCinco();

            Assert.IsTrue(esperado);
        }
        
    }
}
