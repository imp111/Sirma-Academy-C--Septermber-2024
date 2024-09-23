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
string weekday = Console.ReadLine().ToLower(); 
int amount = int.Parse(Console.ReadLine());
double output = 0.0;

if (weekday == "monday" || weekday == "tuesday" || weekday == "wednesday" || weekday == "thursday" || weekday == "friday")
{
    output = products["Weekday"][vegetable] * amount;
}
else if (weekday == "saturday" || weekday == "sunday")
{
    output = products["Weekend"][vegetable] * amount;
}

Console.WriteLine($"{output:F2}");