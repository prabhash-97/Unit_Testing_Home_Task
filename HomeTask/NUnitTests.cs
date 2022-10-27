using CSharpCalculator;
using NUnit.Framework;

[assembly: LevelOfParallelism(2)]
namespace HomeTask
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class NUnitTests
    {

        /*[TestFixtureSetUp]
        public static void ClassInit()
        {
            Console.WriteLine("Pre Condition for test class");
        }*/

        [SetUp]
        public static void TestInit()
        {
            Console.WriteLine("Pre Condition for test");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        private Calculator cal;

        [Test]
        public void Addition_TC()
        {
            double arg1 = 10;
            double arg2 = 10;
            double expected = 20;
            cal = new Calculator();

            double result = cal.Add(arg1, arg2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Abs_TC()
        {
            double arg1 = 10;
            double expected = 10;
            cal = new Calculator();

            double result = cal.Abs(arg1);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Cos_TC()
        {
            double arg1 = 0;
            double expected = 1.0d;
            cal = new Calculator();

            double result = cal.Cos(arg1);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_TC()
        {
            double arg1 = 10;
            double arg2 = 2;
            double expected = 5;
            cal = new Calculator();

            double result = cal.Divide(arg1, arg2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void IsNegative_TC()
        {
            double arg1 = -10;
            bool expected = true;
            cal = new Calculator();

            bool result = cal.isNegative(arg1);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void IsPositive_TC()
        {
            double arg1 = 10;

            bool expected = true;
            cal = new Calculator();

            bool result = cal.isPositive(arg1);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_TC()
        {
            double arg1 = 0;
            double arg2 = 0;
            double expected = 0;
            cal = new Calculator();

            double result = cal.Multiply(arg1, arg2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Pow_TC()
        {
            double arg1 = 6;
            double arg2 = 2;
            double expected = 36;
            cal = new Calculator();

            double result = cal.Pow(arg1, arg2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sin_TC()
        {
            double arg1 = 0;
            double expected = 0;
            cal = new Calculator();

            double result = cal.Sin(arg1);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sqrt_TC()
        {
            double arg1 = 100;
            double expected = 10;
            cal = new Calculator();

            double result = cal.Sqrt(arg1);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sub_TC()
        {
            double arg1 = 10;
            double arg2 = 2;
            double expected = 8;
            cal = new Calculator();

            double result = cal.Sub(arg1, arg2);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TearDown]
        public static void TestClean()
        {
            Console.WriteLine("Post Condition for test");
        }

        /*[TestFixtureTearDown]
        public static void CleanClass()
        {
            Console.WriteLine("Post Condition for test class");
        }*/
    }
}