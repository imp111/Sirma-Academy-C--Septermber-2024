int num = int.Parse(Console.ReadLine());
string output = string.Empty;
if (num == 0 || num < -100 || num > 100)
{
    output = "No";
}
else
{
    output = "Yes";
}

Console.WriteLine(output);
