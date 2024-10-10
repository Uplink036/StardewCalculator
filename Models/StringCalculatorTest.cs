using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace StadewCalculator.Models;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestStringCalculatorExists()
    {
        StringCalculator testObject = new StringCalculator();
        Assert.IsNotNull(testObject);
    }
    [Test]
    public void TeststringToFloatExists()
    {
        StringCalculator testObject = new StringCalculator();
        Assert.IsNotNull(testObject.stringToFloat(""));
    }
    [Test]
    public void TeststringToFloatReturns()
    {
        StringCalculator testObject = new StringCalculator();
        Assert.AreEqual(testObject.stringToFloat("0"), 0.0F);
        Assert.AreEqual(testObject.stringToFloat("-1"), -1.0F);
        Assert.AreEqual(testObject.stringToFloat("1"), 1.0F);
    }
}