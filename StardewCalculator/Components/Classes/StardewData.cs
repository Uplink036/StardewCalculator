namespace StardewCalculator.Components.Classes;

using System.Globalization;
using CsvHelper;
using System.Diagnostics.CodeAnalysis;


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

    public List<ShopStock> data;

    public List<ShopStock> FiltredData => data.Where(
        stock => stock.Crop.ToLower().Contains(SearchText.ToLower())
    ).ToList();

    public StardewData(bool vanillaShop, Shop shop = Shop.PIERRE)
    {
        this.vanillaShop = vanillaShop;
        CurrentShop = shop;
        LoadData();
    }


    [MemberNotNull(nameof(data))]
    private void LoadData()
    {
        string filepath = $@"data/{(vanillaShop ? "vanilla" : "expanded")}/";
        switch (CurrentShop)
        {
            case Shop.PIERRE:
                filepath += "pierres_general_store.csv";
                break;
            case Shop.JOJAMART:
                filepath += "jojamart.csv";
                break;
            case Shop.OASIS:
                filepath += "oasis.csv";
                break;
            default:
                throw new Exception("Unknown shop. Unable to load data");
        }

        var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filepath);
        using (var reader = new StreamReader(path))
        {
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                data = csv.GetRecords<ShopStock>().ToList<ShopStock>();
            }
        }
    }

    public override string ToString()
    {
        return $"{(vanillaShop ? "Vanilla" : "Expanded")} {System.Enum.GetName(CurrentShop)} with crops: {string.Join(", ", data.Take(10).ToList())}";
    }
    
}