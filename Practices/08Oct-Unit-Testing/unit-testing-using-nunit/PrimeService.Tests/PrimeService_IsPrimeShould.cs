using NUnit.Framework;

namespace PrimeService.Tests;

[TestFixture]
public class PrimeService_IsPrimeShould
{
    private Services.PrimeService _primeService;
    [SetUp]
    public void Setup()
    {
        _primeService = new Services.PrimeService();
    }

    [Test]
    public void IsPrime_InputIs1_ReturnFalse()
    {
        // Arrange
        bool result = _primeService.IsPrime(1);

        //Assert
        Assert.That(result, Is.False, "1 should not be prime");
    }

    [Test]
    public void IsPrime_InputIs2_ReturnTrue()
    {
        bool result = _primeService.IsPrime(2);
        Assert.That(result, Is.True, "2 is Prime");
    }

    [TestCase(-1)]
    [TestCase(0)]
    [TestCase(1)]
    public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
    {
        var result = _primeService.IsPrime(value);
        Assert.That(result, Is.False, $"{value} should not be prime");
    }

    [TestCase(4)]
    [TestCase(6)]
    [TestCase(8)]
    public void IsPrime_ValuesIsEven_ReturnFalse(int value)
    {
        bool result = _primeService.IsPrime(value);
        Assert.That(result, Is.False, $"{value} should not be prime");
    }

    [TestCase(3)]
    [TestCase(5)]
    [TestCase(7)]
    public void IsPrime_ValuesIs357_ReturnTrue(int value)
    {
        bool result = _primeService.IsPrime(value);
        Assert.That(result, Is.True, $"{value} is Prime");
    }
}
