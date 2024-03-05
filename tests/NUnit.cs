using api;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace tests;

[TestFixture]
public class NUnit
{
    [Test]
    public void Add_TwoIntegers_ReturnsCorrectSum()
    {
        MathOperations mathOperations = new MathOperations();
        int result = mathOperations.Add(5, 7);
        Assert.AreEqual(12, result);
    }

    [Test]
    public void Subtract_TwoIntegers_ReturnsCorrectDifference()
    {
        MathOperations mathOperations = new MathOperations();
        int result = mathOperations.Subtract(10, 3);
        Assert.AreEqual(7, result);
    }

    [Test]
    public void Multiply_TwoIntegers_ReturnsCorrectProduct()
    {
        MathOperations mathOperations = new MathOperations();
        int result = mathOperations.Multiply(4, 5);
        Assert.AreEqual(20, result);
    }

    [Test]
    public void Divide_TwoIntegers_ReturnsCorrectQuotient()
    {
        MathOperations mathOperations = new MathOperations();
        int result = mathOperations.Divide(10, 2);
        Assert.AreEqual(5, result);
    }

    
}