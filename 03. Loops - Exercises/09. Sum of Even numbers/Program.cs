int n = int.Parse(Console.ReadLine());

int sum = 0;
int evenNum = 2;
for (int i = 0; i < n; i++)
{
    sum += evenNum;
    evenNum += 2;
}

System.Console.WriteLine(sum);