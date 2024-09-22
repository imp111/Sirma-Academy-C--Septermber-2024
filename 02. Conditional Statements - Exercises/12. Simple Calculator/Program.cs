double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();
double output = 0.0;

switch (operation.ToLower())
{
    case "add": output = a + b; break;
    case "subtract": output = a - b; break;
    case "multiply": output = a * b; break;
    case "divide": output = a / b; break;
}

Console.WriteLine($"{output:F2}");