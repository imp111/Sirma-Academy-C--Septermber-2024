int speed = int.Parse(Console.ReadLine());
string output = string.Empty;

if (speed <= 10) output = "slow";
else if (speed > 10 && speed <= 60) output = "average";
else if (speed > 60 && speed <= 120) output = "fast";
else if (speed > 120 && speed <= 160) output = "super-fast";
else if (speed > 160) output = "turbo-fast";
else output = "invalid speed";

Console.WriteLine(output);