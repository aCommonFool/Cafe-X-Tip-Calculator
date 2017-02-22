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

            // Test no service charge applied.
            l_TestData.Add("Cola");
            l_TestData.Add("Coffee");
            Assert.AreEqual(m_BillCalc.Calculate(l_TestData), 1.5);

            // Test 10% servcice charge applied
            l_TestData.Add("Cheese Sandwich");          
            Assert.AreEqual(m_BillCalc.Calculate(l_TestData), 3.85);

            // Test 20% servcice charge applied
            l_TestData.Add("Steak Sandwich");
            Assert.AreEqual(m_BillCalc.Calculate(l_TestData), 9.6);

            // Test Unknown element
            l_TestData.Add("UNKnOWN");
            Assert.AreEqual(m_BillCalc.Calculate(l_TestData), 9.6);
        }
    }
}