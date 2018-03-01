using System.Linq;

public class Smartphone : IPhonebook, IBrowser
{
    public Smartphone()
    {
    }

    public string Call(string phoneNumber)
    {
        if (phoneNumber.Any(d => !char.IsDigit(d)))
        {
            return "Invalid number!";
        }

        return $"Calling... {phoneNumber}";
    }

    public string BrowseSite(string siteName)
    {
        if (siteName.Any(c => char.IsDigit(c)))
        {
            return $"Invalid URL!";
        }

        return $"Browsing: {siteName}!";
    }
}

