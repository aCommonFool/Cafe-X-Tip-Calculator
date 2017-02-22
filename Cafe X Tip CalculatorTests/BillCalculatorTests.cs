using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafe_X_Tip_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_X_Tip_Calculator.Tests
{
    [TestClass()]
    public class BillCalculatorTests
    {

        [TestMethod()]
        public void CalculateTest()
        {
            BillCalculator m_BillCalc = new BillCalculator();
            List<String> l_TestData = new List<string>();

            // Ensure empty list works
            Assert.AreEqual(m_BillCalc.Calculate(l_TestData), 0.0);

            l_TestData.Add("Cola");
            l_TestData.Add("Coffee");
            l_TestData.Add("Cheese Sandwich");
            l_TestData.Add("Steak Sandwich");

            // Test each element
            Assert.AreEqual(m_BillCalc.Calculate(l_TestData), 8.0);

            l_TestData.Add("UNKnOWN");

            // Test Unknown element
            Assert.AreEqual(m_BillCalc.Calculate(l_TestData), 8.0);
        }
    }
}