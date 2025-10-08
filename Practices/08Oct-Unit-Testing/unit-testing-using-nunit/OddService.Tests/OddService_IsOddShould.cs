namespace OddService.Tests;

public class OddService_IsOddShould
{
    private OddService _oddService;
    [SetUp]
    public void Setup()
    {
        _oddService = new OddService();
    }

    [Test]
    public void IsOdd_InputIs1_ReturnTrue()
    {
        //Arrange
        bool result = _oddService.IsOdd(1);
        //Assert
        Assert.That(result, Is.True, $"{result} is Odd");
    }

    [TestCase(2)]
    [TestCase(4)]
    [TestCase(6)]
    public void IsOdd_ValuesIs246_ReturnFalse(int value)
    {
        //Arrange
        bool result = _oddService.IsOdd(value);

        //Assert
        Assert.That(result, Is.False, $"{value} is Not Odd");
    }
}
