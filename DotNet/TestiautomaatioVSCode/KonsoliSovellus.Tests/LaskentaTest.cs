namespace KonsoliSovellus.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        // Arrange
        Laskenta laskenta = new();
        int a = 2;
        int b = 3;
        int odotettuTulos = 5;

        // Act
        int tulos = laskenta.Summa(a, b);
        
        // Assert
        Assert.AreEqual(odotettuTulos, tulos);
    }
}
