using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeTask_MSTest
{
    [TestClass]
    public class MSTest
    {

        /*[ClassInitialize]
        public static void ClassInit()
        {
            Console.WriteLine("Pre Condition for test class");
        }

        [TestInitialize]
        public static void TestInit()
        {
            Console.WriteLine("Pre Condition for test");
        }*/

        [TestMethod]
        public void TestMethod1()
        {
        }

        private Calculator cal;

        [TestMethod]
        public void Addition_TC()
        {
            double arg1 = 10;
            double arg2 = 10;
            double expected = 20;
            cal = new Calculator();

            double result = cal.Add(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Abs_TC()
        {
            double arg1 = 10;
            double expected = 10;
            cal = new Calculator();

            double result = cal.Abs(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Cos_TC()
        {
            double arg1 = 0;
            double expected = 1.0d;
            cal = new Calculator();

            double result = cal.Cos(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Divide_TC()
        {
            double arg1 = 10;
            double arg2 = 2;
            double expected = 5;
            cal = new Calculator();

            double result = cal.Divide(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsNegative_TC()
        {
            double arg1 = -10;
            bool expected = true;
            cal = new Calculator();

            bool result = cal.isNegative(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsPositive_TC()
        {
            double arg1 = 10;

            bool expected = true;
            cal = new Calculator();

            bool result = cal.isPositive(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiply_TC()
        {
            double arg1 = 0;
            double arg2 = 0;
            double expected = 0;
            cal = new Calculator();

            double result = cal.Multiply(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Pow_TC()
        {
            double arg1 = 0;
            double arg2 = 0;
            double expected = 0;
            cal = new Calculator();

            double result = cal.Pow(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sin_TC()
        {
            double arg1 = 0;
            double expected = 0;
            cal = new Calculator();

            double result = cal.Sin(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sqrt_TC()
        {
            double arg1 = 100;
            double expected = 10;
            cal = new Calculator();

            double result = cal.Sqrt(arg1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Sub_TC()
        {
            double arg1 = 10;
            double arg2 = 2;
            double expected = 8;
            cal = new Calculator();

            double result = cal.Sub(arg1, arg2);
            Assert.AreEqual(expected, result);
        }

   
      
        /* [TestCleanup]
         public static void TestClean()
         {
             Console.WriteLine("Post Condition for test");
         }

         [ClassCleanup]
         public static void CleanClass()
         {
             Console.WriteLine("Post Condition for test class");
         }*/
    }
}