namespace StardewCalculator.Tests;
using StardewCalculator.Components.Classes;

public class StardewDataTests
{
    [Test]
    public void LoadAllShops()
    {
        var pierresVanilla = new StardewData(true, Shop.PIERRE);
        var jojaVanilla = new StardewData(true, Shop.JOJAMART);
        var oasisVanilla = new StardewData(true, Shop.OASIS);

        var pierresExpanded = new StardewData(false, Shop.PIERRE);
        var jojaExpanded = new StardewData(false, Shop.JOJAMART);
        var oasisExpanded = new StardewData(false, Shop.OASIS);

        Assert.That(pierresVanilla.data.Count(), Is.EqualTo(6));
        Assert.That(jojaVanilla.data.Count(), Is.EqualTo(1));
        Assert.That(oasisVanilla.data.Count(), Is.EqualTo(1));

        Assert.That(pierresExpanded.data.Count(), Is.EqualTo(1));
        Assert.That(jojaExpanded.data.Count(), Is.EqualTo(1));
        Assert.That(oasisExpanded.data.Count(), Is.EqualTo(1));
    }
}