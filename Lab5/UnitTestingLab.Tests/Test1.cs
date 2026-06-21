using UnitTestingLab;

namespace UnitTestingLab.Tests
{
    [TestClass]
    public sealed class CalculatorTests
    {
        private Calculator? calculator;

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
    }
}
