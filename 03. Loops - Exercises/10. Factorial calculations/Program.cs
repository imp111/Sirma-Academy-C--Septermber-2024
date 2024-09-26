int input = int.Parse(Console.ReadLine());
int fac = 1;

for (int i = 1; i <= input; i++) 
{
    fac *= i;
}

Console.WriteLine(fac);