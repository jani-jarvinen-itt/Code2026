namespace Testisovellus.Tests
{
    [TestClass]
    public sealed class LaskentaTest
    {
        [TestMethod]
        public void Summa_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var laskenta = new Laskenta();
            int a = 5;
            int b = 3;

            // Act
            int result = laskenta.Summa(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Summa_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var laskenta = new Laskenta();
            int a = -5;
            int b = -3;

            // Act
            int result = laskenta.Summa(a, b);

            // Assert
            Assert.AreEqual(-8, result);
        }
    }
}
