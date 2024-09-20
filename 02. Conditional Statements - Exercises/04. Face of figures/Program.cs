string? figure = Console.ReadLine();
double a, b = 0;

switch (figure?.ToLower())
{
	case "square": a = double.Parse(Console.ReadLine()); Console.WriteLine($"{a * a:F2}"); break;
	case "rectangle": a = double.Parse(Console.ReadLine()); b = double.Parse(Console.ReadLine()); Console.WriteLine($"{a * b:F2}"); break;
	case "circle": a = double.Parse(Console.ReadLine()); Console.WriteLine($"{Math.PI * a * a:F2}"); break;
	case "triangle": a = double.Parse(Console.ReadLine()); b = double.Parse(Console.ReadLine()); Console.WriteLine($"{(a * b) / 2:F2}") ; break;
    default: break;
}