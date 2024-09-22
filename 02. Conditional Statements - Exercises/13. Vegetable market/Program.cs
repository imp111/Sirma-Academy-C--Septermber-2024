Dictionary<string, Dictionary<string, double>> products = new Dictionary<string, Dictionary<string, double>>()
{
     { "Weekday", new Dictionary<string, double>
        {
            { "tomato", 2.50 },
            { "onion", 1.20 },
            { "lettuce", 0.85 },
            { "cucumber", 1.45 },
            { "pepper", 5.50 }
        }
    },
    { "Weekend", new Dictionary<string, double>
        {
            { "tomato", 2.80 },
            { "onion", 1.30 },
            { "lettuce", 0.85 },
            { "cucumber", 1.75 },
            { "pepper", 3.50 }
        }
    }
};

string vegetable = Console.ReadLine();
string weekday = Console.ReadLine(); 
int amount = int.Parse(Console.ReadLine());

switch (weekday.ToLower())
{
    case "monday": Console.WriteLine($"{products["Weekday"][vegetable] * amount:F2}"); ; break;
    case "tuesday": Console.WriteLine($"{products["Weekday"][vegetable] * amount:F2}"); break;
    case "wednesday": Console.WriteLine($"{products["Weekday"][vegetable] * amount:F2}"); break;
    case "thursday": Console.WriteLine($"{products["Weekday"][vegetable] * amount:F2}"); break;
    case "friday": Console.WriteLine($"{products["Weekday"][vegetable] * amount:F2}"); break;
    case "saturday": Console.WriteLine($"{products["Weekend"][vegetable] * amount:F2}"); break;
    case "sunday": Console.WriteLine($"{products["Weekend"][vegetable] * amount:F2}"); break;
    default: Console.WriteLine("error"); break;
}

