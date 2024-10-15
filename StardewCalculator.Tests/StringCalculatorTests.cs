namespace StardewCalculator.Tests;
using StadewCalculator.Models;
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
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
        Assert.That(testObject.stringToFloat("0"), Is.EqualTo(0.0f));
        Assert.That(testObject.stringToFloat("-1"), Is.EqualTo(-1.0f));
        Assert.That(testObject.stringToFloat("1"), Is.EqualTo(1.0f));
    }
}