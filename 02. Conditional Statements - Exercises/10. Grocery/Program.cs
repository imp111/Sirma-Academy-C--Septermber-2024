Dictionary<string, Dictionary<string, double>> test = new Dictionary<string, Dictionary<string, double>>
{
    { "Sofia", new Dictionary<string, double>
        {
            { "tea", 0.50 },
            { "water", 0.80 },
            { "juice", 1.20 },
            { "sweets", 1.45 },
            { "chips", 1.60 }
        }
    },
    { "Plovdiv", new Dictionary<string, double>
        {
            { "tea", 0.40 },
            { "water", 0.70 },
            { "juice", 1.15 },
            { "sweets", 1.30 },
            { "chips", 1.50 }
        }
    },
    { "Varna", new Dictionary<string, double>
        {
            { "tea", 0.45 },
            { "water", 0.70 },
            { "juice", 1.10 },
            { "sweets", 1.35 },
            { "chips", 1.55 }
        }
    }
};

string product = Console.ReadLine();
string town = Console.ReadLine();
int amount = int.Parse(Console.ReadLine());

double output = test[town][product] * amount;
Console.WriteLine($"{output:F2}");