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


    [Test]
    public void TestGetHistory()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.add(1);
        calculator.calculate();
        List<float> history = calculator.getHistory();
        Assert.That(history, Is.Not.Null, "History should not be null after a calculation.");
        Assert.That(history.Count, Is.EqualTo(1), "History should contain 1 entry after a single calculation.");
        Assert.That(history[0], Is.EqualTo(1.0F), "First history entry should be 1.0F.");
    }

    [Test]
    public void TestHistoryAfterClear()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.add(1);
        calculator.calculate();
        calculator.clear();
        List<float> history = calculator.getHistory();
        Assert.That(history, Is.Not.Null, "History should not be null after clearing the calculator.");
        Assert.That(history.Count, Is.EqualTo(0), "History should be empty after clearing the calculator.");
    }

}
