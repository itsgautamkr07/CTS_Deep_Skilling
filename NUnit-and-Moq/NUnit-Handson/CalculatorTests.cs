using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void Add_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(10, calculator.Add(5, 5));
    }

    [Test]
    public void Subtract_ReturnsCorrectResult()
    {
        Calculator calculator = new Calculator();
        Assert.AreEqual(2, calculator.Subtract(5, 3));
    }
}
