int n = int.Parse(Console.ReadLine()); // 3
int sum = 1;

for (int i = 1; i < n; i++)
{
    sum = sum + (n - i);
}

Console.WriteLine(sum);
