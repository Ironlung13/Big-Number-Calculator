using Microsoft.VisualStudio.TestTools.UnitTesting;
using Big_Number_Calculator;

namespace Tests_For_BNC
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void SimpleTest()
        {
            LargeNumber x1 = "345";
            LargeNumber y1 = "88";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "30360";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void BothPositiveNumbers1()
        {
            LargeNumber x1 = "20000";
            LargeNumber y1 = "2";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "40000";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void BothPositiveNumbers2()
        {
            LargeNumber y1 = "999928273";
            LargeNumber x1 = "24223412312";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "24221674839305097176";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void BothNegativeNumbers1()
        {
            LargeNumber x1 = "-333333333";
            LargeNumber y1 = "-80";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "26666666640";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void BothNegativeNumbers2()
        {
            LargeNumber x1 = "-80";
            LargeNumber y1 = "-333333333";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "26666666640";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void BothNegativeNumbers3()
        {
            LargeNumber x1 = "-80918293879871923";
            LargeNumber y1 = "-99928372";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "8086033372433164833899356";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void MultiplyByOne()
        {
            LargeNumber x1 = "80918293879871923";
            LargeNumber y1 = "1";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "80918293879871923";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void MultiplyByNegativeOne()
        {
            LargeNumber x1 = "80918293879871923";
            LargeNumber y1 = "-1";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "-80918293879871923";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void PositiveNegative1()
        {
            LargeNumber x1 = "111111111";
            LargeNumber y1 = "-111111111";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "-12345678987654321";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void PositiveNegative2()
        {
            LargeNumber x1 = "-82398172983812382837";
            LargeNumber y1 = "3";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "-247194518951437148511";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void MultiplyByZero1()
        {
            LargeNumber x1 = "24223412312";
            LargeNumber y1 = "0";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "0";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void MultiplyByZero2()
        {
            LargeNumber x1 = "-24223412312";
            LargeNumber y1 = "0";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "0";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void MultiplyByZero3()
        {
            LargeNumber x1 = "-24223412312";
            LargeNumber y1 = "-0";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "0";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void MultiplyByZero4()
        {
            LargeNumber x1 = "24223412312";
            LargeNumber y1 = "-0";

            LargeNumber result = LargeNumberCalculator.Multiply(x1, y1);
            LargeNumber expected = "0";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
