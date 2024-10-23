namespace StardewCalculator.Components.Classes;

public class StringCalculator
{
    public float stringToFloat(string input)
    {
        // Check if empty
        if (string.Compare(input, "") == 0)
        {
            return 0.0F;
        }
        // Return value
        return float.Parse(input);
    }
}

