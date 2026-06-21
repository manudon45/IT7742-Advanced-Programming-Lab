namespace UnitTestingLab.Tests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }

        #region Addition Tests
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result, "5 + 3 should equal 8");
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -3;
            int expected = 7;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result, "10 + (-3) should equal 7");
        }
        #endregion

        #region Subtraction Tests

        [TestMethod]
        public void Subtract_TwoPositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int a = 10;
            int b = 3;
            int expected = 7;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(expected, result, "10 - 3 should equal 7");
        }

        [TestMethod]
        public void Subtract_SubtractingNegativeNumber_EffectivelyAdds()
        {
            // Arrange
            int a = 10;
            int b = -5;
            int expected = 15;

            // Act
            int result = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(expected, result, "10 - (-5) should equal 15");
        }
        #endregion

        #region Division Tests - Edge Cases
        [TestMethod]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            int a = 10;
            int b = 2;
            int expected = 5;

            // Act
            int result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result, "10 / 2 should equal 5");
        }

        [TestMethod]
        public void Divide_WithRemainder_ReturnsIntegerDivision()
        {
            // Arrange
            int a = 15;
            int b = 4;
            int expected = 3;

            // Act
            int result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result, "15 / 4 should equal 3 (integer division truncates)");
        }

        [TestMethod]
        public void Divide_NegativeDivisor_ReturnsCorrectQuotient()
        {
            // Arrange
            int a = 10;
            int b = -2;
            int expected = -5;

            // Act
            int result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result, "10 / -2 should equal -5");
        }

        [TestMethod]
        public void Divide_BothNegative_ReturnsPositiveQuotient()
        {
            // Arrange
            int a = -10;
            int b = -2;
            int expected = 5;

            // Act
            int result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result, "-10 / -2 should equal 5");
        }

        [TestMethod]
        public void Divide_ZeroDividend_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 5;
            int expected = 0;

            // Act
            int result = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expected, result, "0 / 5 should equal 0");
        }
        #endregion

        #region Factorial Tests - Complex Logic with Boundary Conditions
        [TestMethod]
        public void Factorial_ZeroInput_ReturnsOne()
        {
            // Arrange
            int n = 0;
            int expected = 1;

            // Act
            int result = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, result, "0! should equal 1 (base case)");
        }

        [TestMethod]
        public void Factorial_OneInput_ReturnsOne()
        {
            // Arrange
            int n = 1;
            int expected = 1;

            // Act
            int result = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, result, "1! should equal 1 (base case)");
        }

        [TestMethod]
        public void Factorial_SmallPositiveNumber_ReturnsCorrectValue()
        {
            // Arrange
            int n = 5;
            int expected = 120;

            // Act
            int result = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, result, "5! should equal 120");
        }

        [TestMethod]
        public void Factorial_TwoInput_ReturnsTwo()
        {
            // Arrange
            int n = 2;
            int expected = 2;

            // Act
            int result = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, result, "2! should equal 2");
        }

        [TestMethod]
        public void Factorial_ThreeInput_ReturnsSix()
        {
            // Arrange
            int n = 3;
            int expected = 6;

            // Act
            int result = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, result, "3! should equal 6");
        }

        [TestMethod]
        public void Factorial_FourInput_ReturnsTwentyFour()
        {
            // Arrange
            int n = 4;
            int expected = 24;

            // Act
            int result = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, result, "4! should equal 24");
        }

        [TestMethod]
        public void Factorial_TenInput_ReturnsCorrectValue()
        {
            // Arrange
            int n = 10;
            int expected = 3628800;

            // Act
            int result = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, result, "10! should equal 3,628,800");
        }
        #endregion
    }
}
