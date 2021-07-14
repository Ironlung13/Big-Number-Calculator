using Microsoft.VisualStudio.TestTools.UnitTesting;
using Big_Number_Calculator;

namespace Tests_For_BNC
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void SimpleTest1()
        {
            LargeNumber x1 = "345860";
            LargeNumber y1 = "25";

            LargeNumber result = LargeNumberCalculator.DivideWhole(x1, y1);
            LargeNumber expected = "13834";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void SimpleTest2()
        {
            LargeNumber x1 = "25";
            LargeNumber y1 = "345860";

            LargeNumber result = LargeNumberCalculator.DivideWhole(x1, y1);
            LargeNumber expected = "0";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
