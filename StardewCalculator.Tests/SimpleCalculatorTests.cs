namespace StardewCalculator.Tests;
using StardewCalculator.Components.Classes;
public class SimpleCalculatorTests
{
    [SetUp]
    public void Setup()
    {

    }
    [Test]
    public void TestSimpleCalculatorExist()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        Assert.IsNotNull(calculator);
    }
    [Test]
    public void TestAdd()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        Assert.That(calculator.add, Is.Not.Null);
        //Test 1-9
        Assert.That(calculator.lhs, Is.EqualTo(0));
        calculator.add(1);
        calculator.calculate();
        Assert.That(calculator.lhs, Is.EqualTo(1.0F));
        Assert.That(calculator.lhs, Is.Not.EqualTo(0));
        Assert.That(calculator.lhs, Is.EqualTo(1.0F));
        for (int i = 2; i < 10; i++)
        {
            calculator.add(i);
        }
        calculator.calculate();
        Assert.That(calculator.lhs, Is.Not.EqualTo(0));
        Assert.That(calculator.lhs, Is.EqualTo(23456789.0F));
    }
    [Test]
    public void TestClear()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        Assert.That(calculator.lhs, Is.EqualTo(0));
        calculator.add(1);
        calculator.calculate();
        Assert.That(calculator.lhs, Is.Not.EqualTo(0));
        Assert.That(calculator.lhs, Is.EqualTo(1.0F));
        calculator.clear();
        Assert.That(calculator.lhs, Is.EqualTo(0));
    }
    [Test]
    public void TestSetOp()
    { 
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.add(1);
        calculator.setOp('+');
        calculator.add(1);
        calculator.calculate();
        Assert.That(calculator.lhs, Is.EqualTo(2.0F));
        calculator.setOp('-');
        calculator.add(1);
        calculator.calculate();
        Assert.That(calculator.lhs, Is.EqualTo(1.0F));
        calculator.setOp('*');
        calculator.add(2);
        calculator.calculate();
        Assert.That(calculator.lhs, Is.EqualTo(2.0F));
        calculator.setOp('/');
        calculator.add(2);
        calculator.calculate();
        Assert.That(calculator.lhs, Is.EqualTo(1.0F));
    }

}
