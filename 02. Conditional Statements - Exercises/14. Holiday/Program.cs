double budget = double.Parse(Console.ReadLine());

while (budget < 10 && budget > 5000)
{
    Console.Write("Try different budget!\nBudget: ");
    budget = double.Parse(Console.ReadLine());
}

string season = Console.ReadLine();

while (season.ToLower() != "winter" && season.ToLower() != "summer")
{
    Console.Write("Try using a valid season (winter/summer)!\nSeason: ");
    season = Console.ReadLine();
}

double spent = 0.0;
string rest = string.Empty;
string country = string.Empty;

if (budget <= 100)
{
    if (season == "winter")
    {
        spent = budget * 0.7;
        rest = "Hotel";
    }
    else
    {
        spent = budget * 0.3; 
        rest = "Camp";
    }

    country = "Bulgaria";
}
else if (budget > 100 &&  budget <= 1000)
{
    if (season == "winter")
    {
        spent = budget * 0.8;
        rest = "Hotel";
    }
    else
    {
        spent = budget * 0.4;
        rest = "Camp";
    }

    country = "Europe";
}
else
{
    spent = budget * 0.9;
    rest = "Hotel";
    country = "Asia";
}

Console.WriteLine($"Somewhere in {country}");
Console.WriteLine($"{rest} - {spent:F2}");