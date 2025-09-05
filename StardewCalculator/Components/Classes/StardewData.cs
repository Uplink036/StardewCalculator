namespace StardewCalculator.Components.Classes;

using CsvHelper;

public enum Shop
{
    PIERRE,
    JOJAMART,
    OASIS,
}

public class StardewData
{
    public string SearchText = "";
    Shop CurrentShop { get; set; }

    bool vanillaShop { get; set; }

    public IEnumerable<ShopStock> data;

    StardewData(bool vanillaShop, Shop shop = Shop.PIERRE)
    {
        this.vanillaShop = vanillaShop;
        CurrentShop = shop;

        // var test = new ShopStock();
        // Load data?
    }


    private void LoadData()
    {
        // string filepath = "";
        Console.WriteLine(Directory.GetCurrentDirectory());
    }
    
}