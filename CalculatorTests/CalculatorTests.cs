using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        private readonly Calculator calculate = new Calculator();
        private readonly int a = 10;
        private readonly int b = 2;
        
        [TestMethod()]
        public void AddIntTest()
        {
            Assert.AreEqual(12, calculate.Add(a,b));
        }
        


        [TestMethod()]
        public void DivideIntTest()
        {
            Assert.AreEqual(5, calculate.Divide(a, b));
        }
        

    }
}


