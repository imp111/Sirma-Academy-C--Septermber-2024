int age = int.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());
string output = string.Empty;

if (gender == 'f')
{
    if (age <= 16)
    {
        output = "Miss";
    }
    else
    {
        output = "Ms.";
    }
}
else if (gender == 'f')
{
    if (age <= 16)
    {
        output = "Mr";
    }
    else
    {
        output = "Master";
    }
}

Console.WriteLine(output);