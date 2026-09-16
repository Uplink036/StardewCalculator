namespace StardewCalculator.Tests;
using StardewCalculator.Components.Classes;

public class StardewDataTests
{
    [Test]
    public void LoadVanillaPierres()
    {
        var pierresVanilla = new StardewData(true, Shop.PIERRE);
        Assert.That(pierresVanilla.data.Count(), Is.EqualTo(6), string.Format("Found crops: {0}", pierresVanilla.data));
    }

    [Test]
    public void LoadVanillaJoja()
    {
        var jojaVanilla = new StardewData(true, Shop.JOJAMART);
        Assert.That(jojaVanilla.data.Count(), Is.EqualTo(1), string.Format("Found crops: {0}", jojaVanilla.data));
    }

    [Test]
    public void LoadVanillaOasis()
    {
        var oasisVanilla = new StardewData(true, Shop.OASIS);
        Assert.That(oasisVanilla.data.Count(), Is.EqualTo(1), string.Format("Found crops: {0}", oasisVanilla.data));
    }

    [Test]
    public void LoadExpandedPierres()
    {
        var pierresExpanded = new StardewData(false, Shop.PIERRE);
        Assert.That(pierresExpanded.data.Count(), Is.EqualTo(1), string.Format("Found crops: {0}", pierresExpanded.data));
    }

    [Test]
    public void LoadExpandedJoja()
    {
        var jojaExpanded = new StardewData(false, Shop.JOJAMART);
        Assert.That(jojaExpanded.data.Count(), Is.EqualTo(1), string.Format("Found crops: {0}", jojaExpanded.data));
    }

    [Test]
    public void LoadExpandedOasis()
    {
        var oasisExpanded = new StardewData(false, Shop.OASIS);
        Assert.That(oasisExpanded.data.Count(), Is.EqualTo(1), string.Format("Found crops: {0}", oasisExpanded.data));
    }

    [Test]
    public void FilterData()
    {
        var pierresVanilla = new StardewData(true, Shop.PIERRE);
        pierresVanilla.SearchText = "C";

        Assert.That(pierresVanilla.FiltredData.Count, Is.EqualTo(2));
    }

    [Test]
    public void ToStringVanillaPierres()
    {
        var pierresVanilla = new StardewData(true, Shop.PIERRE);
        Assert.That(pierresVanilla.ToString(), Is.EqualTo("Vanilla PIERRE with crops: Coffee Bean, Pineapple, Pumpkin, Powdermelon, Ancient Fruit, Test Fruit"));
    }

    [Test]
    public void ToStringExpandedOasis()
    {
        var pierresVanilla = new StardewData(false, Shop.OASIS);
        Assert.That(pierresVanilla.ToString(), Is.EqualTo("Expanded OASIS with crops: Beets"));
    }
}