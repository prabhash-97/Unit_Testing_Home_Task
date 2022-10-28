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

        private Calculator cal;

        [Test]
        public void Addition_TC()
        {
            //Arrage
            double arg1 = 10;
            double arg2 = 10;
            double expected = 20;
            cal = new Calculator();

            double result = cal.Add(arg1, arg2);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Abs_TC()
        {
            //Arrage
            var arg1 = 10;
            var expected = 10;
            cal = new Calculator();
            //Act
            var result = cal.Abs(arg1);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Cos_TC()
        {
            //Arrage
            var arg1 = 0;
            var expected = 1.0d;
            cal = new Calculator();
            //Act
            var result = cal.Cos(arg1);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_TC()
        {
            //Arrage
            var arg1 = 10;
            var arg2 = 2;
            var expected = 5;
            cal = new Calculator();
            //Act
            var result = cal.Divide(arg1, arg2);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void IsNegative_TC()
        {
            //Arrage
            var arg1 = -10;
            bool expected = true;
            cal = new Calculator();
            //Act
            bool result = cal.isNegative(arg1);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void IsPositive_TC()
        {
            //Arrage
            var arg1 = 10;
            bool expected = true;

            cal = new Calculator();
            //Act
            bool result = cal.isPositive(arg1);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_TC()
        {
            //Arrage
            var arg1 = 0;
            var arg2 = 0;
            var expected = 0;
            cal = new Calculator();
            //Act
            var result = cal.Multiply(arg1, arg2);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Pow_TC()
        {
            //Arrage
            var arg1 = 6;
            var arg2 = 2.0;
            var expected = 36;
            cal = new Calculator();
            //Act
            var result = cal.Pow(arg1, arg2);
            //Assert
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void Sin_TC()
        {
            //Arrage
            var arg1 = 0;
            var expected = 0;
            cal = new Calculator();
            //Act
            var result = cal.Sin(arg1);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sqrt_TC()
        {
            //Arrage
            var arg1 = 100;
            var expected = 10;
            cal = new Calculator();
            //Act
            var result = cal.Sqrt(arg1);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Sub_TC()
        {
            //Arrage
            var arg1 = 10;
            var arg2 = 2;
            var expected = 8;
            cal = new Calculator();
            //Act
            var result = cal.Sub(arg1, arg2);
            //Assert
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