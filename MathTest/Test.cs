using Math;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            Base b = new Base();
            double res = b.Add(10, 10);
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            Base b = new Base();
            double res = b.Substract(10, 10);
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            Base b = new Base();
            double res = b.Divide(10, 5);
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            Base b = new Base();
            double res = b.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }
}
