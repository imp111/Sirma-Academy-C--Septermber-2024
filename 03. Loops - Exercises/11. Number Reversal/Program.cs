string input = Console.ReadLine();

for (int i = input.Length - 1; i >= 0; i--)
{
    System.Console.Write(input[i]);

    if (i == 0)
    {
        System.Console.WriteLine();
    }
}