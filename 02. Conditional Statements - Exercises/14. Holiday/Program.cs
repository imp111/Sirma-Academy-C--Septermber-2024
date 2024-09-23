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
      
    Console.WriteLine("Somewhere in Bulgaria");
    Console.WriteLine($"{rest} - {spent:F2}");
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

    Console.WriteLine("Somewhere in Europe");
    Console.WriteLine($"{rest} - {spent:F2}");
}
else
{
    spent = budget * 0.9;

    Console.WriteLine("Somewhere in Asia");
    Console.WriteLine($"Hotel - {spent:F2}");
}