namespace StardewCalculator.Components.Classes;

public class ShopStock
{
    required public string Season { get; set; }
    required public string Crop { get; set; }
    required public int SeedCost { get; set; }
    required public int DaysToMature { get; set; }
    required public int DaysForRegrowth { get; set; }

    public override string ToString()
    {
        return Crop;
    }
}
