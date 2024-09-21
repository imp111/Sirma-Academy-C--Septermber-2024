Console.Write("Hour: ");
int hours = int.Parse(Console.ReadLine());

while (hours < 0 || hours > 23)
{ 
    Console.Write("Invalid hour, try again!\nHour: ");
    hours = int.Parse((Console.ReadLine()));
}

Console.Write("Minutes: ");
int minutes = int.Parse(Console.ReadLine());

while (minutes < 0 || minutes > 59)
{
    Console.WriteLine("Invalid minutes, try again!\nMinutes: ");
    minutes = int.Parse((Console.ReadLine()));
}

minutes += 15;

if (minutes > 59 && hours == 23)
{
    hours = 0;
    minutes -= 60;
}
else if (minutes > 59)
{
    hours += 1;
    minutes -= 60;
}

if (minutes >= 0 && minutes < 10)
{
    Console.WriteLine($"After 15 minutes added: {hours}:0{minutes}");
}
else
{
    Console.WriteLine($"After 15 minutes added: {hours}:{minutes}");
}