namespace Laskentaa.Tests
{
    [TestClass]
    public sealed class LaskentaTests
    {
        [TestMethod]
        public void Factorial_Input3_Returns6()
        {
            // Arrange
            int input = 3;

            // Act
            int result = Laskenta.Factorial(input);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Factorial_Input5_Returns120()
        {
            // Arrange
            int input = 5;

            // Act
            int result = Laskenta.Factorial(input);

            // Assert
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void Factorial_Input0_Returns1()
        {
            // Arrange
            int input = 0;

            // Act
            int result = Laskenta.Factorial(input);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Factorial_NegativeInput_ThrowsException()
        {
            // Arrange
            int input = -3;

            // Act
            int result = Laskenta.Factorial(input);
        }

        [TestMethod]
        public void SumOfDigits_Input120_Returns3()
        {
            // Arrange
            int input = 120;

            // Act
            int result = Laskenta.SumOfDigits(input);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SumOfDigits_Input0_Returns0()
        {
            // Arrange
            int input = 0;

            // Act
            int result = Laskenta.SumOfDigits(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SumOfDigits_NegativeNumber_ReturnsPositiveSum()
        {
            // Arrange
            int input = -123;

            // Act
            int result = Laskenta.SumOfDigits(input);

            // Assert
            Assert.AreEqual(6, result);
        }
    }
}
