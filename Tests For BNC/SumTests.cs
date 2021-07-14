using Microsoft.VisualStudio.TestTools.UnitTesting;
using Big_Number_Calculator;

namespace Tests_For_BNC
{
    [TestClass]
    public class SumTests
    {
        [TestMethod]
        public void BothPositiveNumbers()
        {
            LargeNumber x1 = "30000";
            LargeNumber y1 = "23000";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "53000";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void BothNegativeNumbers()
        {
            LargeNumber x1 = "-30000";
            LargeNumber y1 = "-23000";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "-53000";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void OneNegativeOnePositiveNumber1()
        {
            LargeNumber x1 = "-30000";
            LargeNumber y1 = "23000";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "-7000";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void OneNegativeOnePositiveNumber2()
        {
            LargeNumber x1 = "30000";
            LargeNumber y1 = "-23000";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "7000";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void NegativeZeroTest1()
        {
            LargeNumber x1 = "30000";
            LargeNumber y1 = "-0";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "30000";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void NegativeZeroTest2()
        {
            LargeNumber x1 = "-30000";
            LargeNumber y1 = "-0";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "-30000";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void GiganticNumbersTest1()
        {
            LargeNumber x1 = "123456789123456789123456789";
            LargeNumber y1 = "321321321321321321321";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "123457110444778110444778110";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void GiganticNumbersTest2()
        {
            LargeNumber x1 = "-123456789123456789123456789";
            LargeNumber y1 = "-321321321321321321321";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "-123457110444778110444778110";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void GiganticNumbersTest3()
        {
            LargeNumber x1 = "123456789123456789123456789";
            LargeNumber y1 = "-321321321321321321321";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "123456467802135467802135468";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void GiganticNumbersTest4()
        {
            LargeNumber x1 = "-123456789123456789123456789";
            LargeNumber y1 = "321321321321321321321";

            LargeNumber result = LargeNumberCalculator.Add(x1, y1);
            LargeNumber expected = "-123456467802135467802135468";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
