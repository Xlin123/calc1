using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp2;

namespace TestProj1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestBadMultiply1()
        {
            string answer = Calculator.Multiply("asd", "123");
            Assert.AreEqual("--", answer);
        }
        [TestMethod]
        public void TestBadMultiply2()
        {
            string answer = Calculator.Multiply("123", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestBadMultiply3()
        {
            string answer = Calculator.Multiply("asd", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestGoodMultiply1()
        {
            string answer = Calculator.Multiply("1", "0");
            Assert.AreEqual("0", answer);
        }
        [TestMethod]
        public void TestGoodMultiply2()
        {
            string answer = Calculator.Multiply("1", "3");
            Assert.AreEqual("3", answer);
        }

        [TestMethod]
        public void TestGoodMultiply3()
        {
            string answer = Calculator.Multiply("1.25", "2");
            Assert.AreEqual("2.50", answer);
        }

        [TestMethod]
        public void TestGoodMultiply4()
        {
            string answer = Calculator.Multiply("1.251312", "2123123123123123123131231");
            Assert.AreEqual("2656689441441441441451586.9251", answer);
        }
        [TestMethod]
        public void TestBadAdd1()
        {
            string answer = Calculator.Add("asd", "123");
            Assert.AreEqual("--", answer);
        }
        [TestMethod]
        public void TestBadAdd2()
        {
            string answer = Calculator.Add("123", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestBadAdd3()
        {
            string answer = Calculator.Add("asd", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestGoodAdd1()
        {
            string answer = Calculator.Add("1", "0");
            Assert.AreEqual("1", answer);
        }
        [TestMethod]
        public void TestGoodAdd2()
        {
            string answer = Calculator.Add("1", "3");
            Assert.AreEqual("4", answer);
        }

        [TestMethod]
        public void TestGoodAdd3()
        {
            string answer = Calculator.Add("1.25", "2");
            Assert.AreEqual("3.25", answer);
        }
        [TestMethod]
        public void TestBadDivide1()
        {
            string answer = Calculator.Divide("asd", "123");
            Assert.AreEqual("--", answer);
        }
        [TestMethod]
        public void TestBadDivide2()
        {
            string answer = Calculator.Divide("123", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestBadDivide3()
        {
            string answer = Calculator.Divide("asd", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestGoodDivide1()
        {
            string answer = Calculator.Divide("1", "0");
            Assert.AreEqual("--", answer);
        }
        [TestMethod]
        public void TestGoodDivide2()
        {
            string answer = Calculator.Divide("1", "2");
            Assert.AreEqual("0.5", answer);
        }

        [TestMethod]
        public void TestGoodDivide3()
        {
            string answer = Calculator.Divide("1.25", "2");
            Assert.AreEqual("0.625", answer);
        }
        [TestMethod]
        public void TestBadSubtract1()
        {
            string answer = Calculator.Subtract("asd", "123");
            Assert.AreEqual("--", answer);
        }
        [TestMethod]
        public void TestBadSubtract2()
        {
            string answer = Calculator.Subtract("123", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestBadSubtract3()
        {
            string answer = Calculator.Subtract("asd", "asd");
            Assert.AreEqual("--", answer);
        }

        [TestMethod]
        public void TestGoodSubtract1()
        {
            string answer = Calculator.Subtract("1", "0");
            Assert.AreEqual("1", answer);
        }
        [TestMethod]
        public void TestGoodSubtract2()
        {
            string answer = Calculator.Subtract("1", "3");
            Assert.AreEqual("-2", answer);
        }

        [TestMethod]
        public void TestGoodSubtract3()
        {
            string answer = Calculator.Subtract("1.25", "2");
            Assert.AreEqual("-0.75", answer);
        }
    }


}
