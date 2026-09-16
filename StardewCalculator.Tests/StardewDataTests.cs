namespace StardewCalculator.Tests;
using StardewCalculator.Components.Classes;

public class StardewDataTests
{
    [Test]
    public void LoadVanillaPierres()
    {
        var pierresVanilla = new StardewData(true, Shop.PIERRE);
        Assert.That(pierresVanilla.data.Count(), Is.EqualTo(6));
    }

    [Test]
    public void LoadVanillaJoja()
    {
        var jojaVanilla = new StardewData(true, Shop.JOJAMART);
        Assert.That(jojaVanilla.data.Count(), Is.EqualTo(1));
    }

    [Test]
    public void LoadVanillaOasis()
    {
        var oasisVanilla = new StardewData(true, Shop.OASIS);
        Assert.That(oasisVanilla.data.Count(), Is.EqualTo(1));
    }

    [Test]
    public void LoadExpandedPierres()
    {
        var pierresExpanded = new StardewData(false, Shop.PIERRE);
        Assert.That(pierresExpanded.data.Count(), Is.EqualTo(1));
    }

    [Test]
    public void LoadExpandedJoja()
    {
        var jojaExpanded = new StardewData(false, Shop.JOJAMART);
        Assert.That(jojaExpanded.data.Count(), Is.EqualTo(1));
    }

    [Test]
    public void LoadExpandedOasis()
    {
        var oasisExpanded = new StardewData(false, Shop.OASIS);
        Assert.That(oasisExpanded.data.Count(), Is.EqualTo(1));
    }

    [Test]
    public void FilterData()
    {
        var pierresVanilla = new StardewData(true, Shop.PIERRE);
        pierresVanilla.SearchText = "C";

        Assert.That(pierresVanilla.FiltredData.Count, Is.EqualTo(2));
    }
}