using CSharpCalculator;
using NUnit.Framework;

namespace HomeTask
{
    [TestFixture]
    public class NUnitTestsDataDriven
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

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase("1", 0, ExpectedResult = 1)]
        [TestCase(0, 1, ExpectedResult = 1)]
        [TestCase(1, 1, ExpectedResult = 2)]
        public double Add_TC(double x, double y)
        {
            cal= new Calculator();
            return cal.Add(x, y);
        }

        [TestCase(0,  ExpectedResult = 0)]
        [TestCase(10,  ExpectedResult = 10)]
        [TestCase(568560,  ExpectedResult = 568560)]
        [TestCase(-891,  ExpectedResult = 891)]
        public double Abs_TC(double x)
        {
            cal = new Calculator();
            return cal.Abs(x);
        }

        [TestCase(0, ExpectedResult = 1.0d)]
        [TestCase(1, ExpectedResult = 0.54030230586813977d)]
        [TestCase(30, ExpectedResult = 0.15425144988758405d)]
        [TestCase(90, ExpectedResult = -0.44807361612917013d)]
        public double Cos_TC(double x)
        {
            cal = new Calculator();
            return cal.Cos(x);
        }
        
        [TestCase(10, 5, ExpectedResult = 2)]
        [TestCase(10, 1, ExpectedResult = 10)]
        [TestCase(500, 2, ExpectedResult = 250)]
        [TestCase(3, 2, ExpectedResult = 1.5)]
        public double Divide_TC(double x,double y)
        {
            cal = new Calculator();
            return cal.Divide(x,y);
        }


        [TestCase(-10, ExpectedResult = true)]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(568560, ExpectedResult = false)]
        [TestCase(-891, ExpectedResult = true)]
        public bool isNegative_TC(double x)
        {
            cal = new Calculator();
            return cal.isNegative(x);
        }

        [TestCase(10, ExpectedResult = true)]
        [TestCase(890, ExpectedResult = true)]
        [TestCase(568560, ExpectedResult = true)]
        [TestCase(-891, ExpectedResult = false)]
        public bool isPositive_TC(double x)
        {
            cal = new Calculator();
            return cal.isPositive(x);
        }

        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(10, 0, ExpectedResult = 0)]
        [TestCase(3, 2, ExpectedResult = 6)]
        [TestCase(1, 4, ExpectedResult = 4)]
        public double Multipy_TC(double x,double y)
        {
            cal = new Calculator();
            return cal.Multiply(x,y);
        }

        [TestCase(6, 2.0, ExpectedResult = 36)]
        [TestCase(3, 3.0, ExpectedResult = 27)]
        [TestCase(202, 4.0, ExpectedResult = 1664966416)]
        [TestCase(1, 1.0, ExpectedResult = 1)]
        public double Power_TC(object x,object y)
        {
            cal = new Calculator();
            return cal.Pow(x,y);
        }

        
        [TestCase(90, ExpectedResult = 0.89399666360055785d)]
        [TestCase(45, ExpectedResult = 0.85090352453411844d)]
        [TestCase(Double.NaN, ExpectedResult = "NaN")]
        [TestCase(60, ExpectedResult = -0.30481062110221668d)]
        public double Sin_TC(double x)
        {
            cal = new Calculator();
            return cal.Sin(x);
        }

        [TestCase(0, ExpectedResult = 0)]
        [TestCase(100, ExpectedResult = 10)]
        [TestCase(625, ExpectedResult = 25)]
        [TestCase(144, ExpectedResult = 12)]
        public double Sqrt_TC(double x)
        {
            cal = new Calculator();
            return cal.Sqrt(x);
        }

        [TestCase(10,2, ExpectedResult = 8)]
        [TestCase(100, 2, ExpectedResult = 98)]
        [TestCase(525,300, ExpectedResult = 225)]
        [TestCase(144,44, ExpectedResult = 100)]
        public double Sub_TC(double x, double y)
        {
            cal = new Calculator();
            return cal.Sub(x,y);
        }
        /*[TearDown]
        public static void TestClean()
        {
            Console.WriteLine("Post Condition for test");
        }

       [TestFixtureTearDown]
        public static void CleanClass()
        {
            Console.WriteLine("Post Condition for test class");
        }*/
    }
}