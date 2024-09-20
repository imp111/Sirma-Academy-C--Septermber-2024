int num = int.Parse(Console.ReadLine());
string output = string.Empty;

if (num % 2 == 0)
{
    output = "even";
}
else
{
    output = "odd";
}

Console.WriteLine(output);