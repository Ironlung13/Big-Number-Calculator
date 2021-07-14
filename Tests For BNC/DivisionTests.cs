using Microsoft.VisualStudio.TestTools.UnitTesting;
using Big_Number_Calculator;
using System;

namespace Tests_For_BNC
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void SimpleTestDiv1()
        {
            LargeNumber x1 = "345860";
            LargeNumber y1 = "25";

            LargeNumber result = LargeNumberCalculator.DivideWhole(x1, y1);
            LargeNumber expected = 13834;
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void SimpleTestDiv2()
        {
            LargeNumber x1 = "25";
            LargeNumber y1 = "345860";

            LargeNumber result = LargeNumberCalculator.DivideWhole(x1, y1);
            LargeNumber expected = 0;
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void SimpleTestDiv3()
        {
            LargeNumber x1 = "4";
            LargeNumber y1 = "2";

            LargeNumber result = LargeNumberCalculator.DivideWhole(x1, y1);
            LargeNumber expected = 2;
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void SimpleTestMod1()
        {
            LargeNumber x1 = "345860";
            LargeNumber y1 = "25";

            LargeNumber result = LargeNumberCalculator.DivideMod(x1, y1);
            LargeNumber expected = 345860 % 25;
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void SimpleTestMod2()
        {
            LargeNumber x1 = "25";
            LargeNumber y1 = "345860";

            LargeNumber result = LargeNumberCalculator.DivideMod(x1, y1);
            LargeNumber expected = 25;
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void SimpleTestMod3()
        {
            LargeNumber x1 = "5";
            LargeNumber y1 = "2";

            LargeNumber result = LargeNumberCalculator.DivideMod(x1, y1);
            LargeNumber expected = 1;
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void LargeNumbersDiv1()
        {
            LargeNumber x1 = "123123123123123123123";
            LargeNumber y1 = "45454545454545";

            LargeNumber result = LargeNumberCalculator.DivideWhole(x1, y1);
            LargeNumber expected = 2708708;
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void LargeNumbersDiv2()
        {
            LargeNumber x1 = "1231212312312412323120312312312312312300";
            LargeNumber y1 = "454545454223300054545";

            LargeNumber result = LargeNumberCalculator.DivideWhole(x1, y1);
            LargeNumber expected = "2708667089007047498";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void LargeNumbersMod1()
        {
            LargeNumber x1 = "123123123123123123123";
            LargeNumber y1 = "45454545454545";

            LargeNumber result = LargeNumberCalculator.DivideMod(x1, y1);
            LargeNumber expected = "32214033445263";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void LargeNumbersMod2()
        {
            LargeNumber x1 = "7827292738291123123123123123123123";
            LargeNumber y1 = "892838273871827387";

            LargeNumber result = LargeNumberCalculator.DivideMod(x1, y1);
            LargeNumber expected = "779286564306941827";
            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DivideByZeroDiv()
        {
            LargeNumber x1 = "-7827292738291123123123123123123123";
            LargeNumber y1 = "0";

            LargeNumberCalculator.DivideWhole(x1, y1);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DivideByZeroMod()
        {
            LargeNumber x1 = "-7827292738291123123123123123123123";
            LargeNumber y1 = "0";

            LargeNumberCalculator.DivideMod(x1, y1);
        }
    }
}
