namespace StardewCalculator.Components.Classes;

public class ShopStock
{
    required public string Season { get; set; }
    required public string Crop { get; set; }
    required public int SeedCost { get; set; }
    required public int Mature { get; set; }
    required public int Harvest { get; set; }
}