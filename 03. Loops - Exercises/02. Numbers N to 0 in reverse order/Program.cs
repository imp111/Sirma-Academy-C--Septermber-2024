int num = int.Parse(Console.ReadLine());

while (Int32.IsNegative(num))
{
    num = int.Parse(Console.ReadLine());
}

for (int i = num; i >= 0; i--)
{
    System.Console.WriteLine(i);
}