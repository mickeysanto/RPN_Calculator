using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RPN_Unit_Testing
{
    [TestClass]
    public class RpnInputManagerTests
    {
        private RPN_Calculator.RpnInputManager inputManager = new RPN_Calculator.RpnInputManager();
        private string result = "";

        [TestMethod]
        public void Test_MultiLineAddition()
        {
            Assert.AreEqual(inputManager.ProcessInput("5"), "5");
            Assert.AreEqual(inputManager.ProcessInput("8"), "8");
            Assert.AreEqual(inputManager.ProcessInput("+"), "13");
        }

        [TestMethod]
        public void Test_SingleLineAddition()
        {
            Assert.AreEqual(inputManager.ProcessInput("5 5 5 8 + + -"), "-13");
            Assert.AreEqual(inputManager.ProcessInput("13 +"), "0");
        }

        [TestMethod]
        public void Test_MultiplicationAddition()
        {
            Assert.AreEqual(inputManager.ProcessInput("-3"), "-3");
            Assert.AreEqual(inputManager.ProcessInput("-2"), "-2");
            Assert.AreEqual(inputManager.ProcessInput("*"), "6");
            Assert.AreEqual(inputManager.ProcessInput("5"), "5");
            Assert.AreEqual(inputManager.ProcessInput("+"), "11");
        }

        [TestMethod]
        public void Test_SubtractionDivision()
        {
            Assert.AreEqual(inputManager.ProcessInput("5"), "5");
            Assert.AreEqual(inputManager.ProcessInput("9"), "9");
            Assert.AreEqual(inputManager.ProcessInput("1"), "1");
            Assert.AreEqual(inputManager.ProcessInput("-"), "8");
            Assert.AreEqual(inputManager.ProcessInput("/"), "0.625");
        }

        [TestMethod]
        public void Test_MultiAndSingleLine()
        {
            Assert.AreEqual(inputManager.ProcessInput("1 1 2"), "2");
            Assert.AreEqual(inputManager.ProcessInput("+"), "3");
            Assert.AreEqual(inputManager.ProcessInput("-"), "-2");
        }

        [TestMethod]
        public void Test_SingleLineMixedOperations()
        {
            Assert.AreEqual(inputManager.ProcessInput("1 1 - 2 +"), "2");
            Assert.AreEqual(inputManager.ProcessInput("2 2 + 3 - 4"), "4");
            Assert.AreEqual(inputManager.ProcessInput("-"), "-3");
        }
    }
}
