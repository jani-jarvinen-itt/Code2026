using AspNetMvcDevOpsDemo.Services;

namespace AspNetMvcDevOpsDemo.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            CalculationService calculationService = new();
            int a = 5;
            int b = 10;

            // Act
            int result = calculationService.CalculateSum(a, b);

            // Assert
            Assert.AreEqual(15, result);
        }
    }
}
