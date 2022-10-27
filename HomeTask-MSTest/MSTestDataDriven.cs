using CSharpCalculator;

namespace HomeTask_MSTest
{
    [TestClass]
    public class MSTestDataDriven
    {
        private Calculator cal;

        [TestMethod]
        [DataRow(0, 10, 10)]
        [DataRow(1, 10, 11)]
        [DataRow(10, 1, 11)]
        [DataRow(2, 4, 6)]
        public void Add_TC(double x, double y, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Add(x, y);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(10, 0)]
        [DataRow(1,1)]
        [DataRow(2, 2)]
        public void Abs_TC(double x, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Abs(x);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(0, 1.0d)]
        [DataRow(1, 0.54030230586813977d)]
        [DataRow(30, 0.15425144988758405d)]
        [DataRow(90, -0.44807361612917013d)]
        public void Cos_TC(double x, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Cos(x);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(10, 10, 1)]
        [DataRow(10, 1, 10)]
        [DataRow(1, 10, 0.1)]
        [DataRow(12, 4, 3)]
        public void Divide_TC(double x, double y, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Divide(x,y);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(10, false)]
        [DataRow(-10, true)]
        [DataRow(1, false)]
        [DataRow(-2, true)]
        public void isNegative_TC(double x,  bool z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            bool result = myCalculator.isNegative(x);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(-10, false)]
        [DataRow(10, true)]
        [DataRow(-1, false)]
        [DataRow(2, true)]
        public void isPositive_TC(double x, bool z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            bool result = myCalculator.isPositive(x);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(0, 10, 0)]
        [DataRow(10, 0, 0)]
        [DataRow(1, 10, 10)]
        [DataRow(10, 1, 10)]
        [DataRow(2, 4, 8)]
        public void Multiply_TC(double x, double y, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Multiply(x, y);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(6,2,36)]
        [DataRow(3.5, 3, 42.875)]
        [DataRow(202, 4, 1664966416)]
        [DataRow(1, 1, 1)]
        public void Pow_TC(double x, double y, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Pow(x, y);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(90, 0.89399666360055785d)]
        [DataRow(45, 0.85090352453411844d)]
        [DataRow(0, 0)]
        [DataRow(60, -0.30481062110221668d)]
        public void Sin_TC(double x, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Sin(x);
            // Assert
            Assert.AreEqual(z, result);
        }

        [TestMethod]
        [DataRow(100, 10)]
        [DataRow(1,1)]
        [DataRow(144, 12)]
        [DataRow(625,25)]
        public void Sqrt_TC(double x, double z)
        {
            // Arrange
            Calculator myCalculator = new Calculator();
            // Act
            double result = myCalculator.Sqrt(x);
            // Assert
            Assert.AreEqual(z, result);
        }
     
 
    }
}
