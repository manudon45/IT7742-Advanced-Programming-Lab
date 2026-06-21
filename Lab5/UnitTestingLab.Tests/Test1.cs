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
    }
}
