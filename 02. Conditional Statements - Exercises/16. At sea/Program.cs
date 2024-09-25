int days = int.Parse(Console.ReadLine());
string typeOfRoom = Console.ReadLine();
string assessment = Console.ReadLine();

switch (typeOfRoom.toLower())
{
    case "apartment":
        totalPrice = (days - 1) * 50.00;
        
        if (days < 10)
        {
            totalPrice = totalPrice - totalPrice * 30 / 100;
        }
        else if (days <= 15 && days >= 10)
        {
            totalPrice = totalPrice - totalPrice * 35 / 100;
        }
        else 
        {
            totalPrice = totalPrice - totalPrice * 50 / 100;
        }

        break;
    case "single room":
        totalPrice = (days - 1) * 25.00;
        break;
    case "presidential":
        totalPrice = (days - 1) * 100.00;

        if (days < 10)
        {
            totalPrice = totalPrice - totalPrice * 10 / 100;
        }
        else if (days <= 15 && days >= 10)
        {
            totalPrice = totalPrice - totalPrice * 15 / 100;
        }
        else 
        {
            totalPrice = totalPrice - totalPrice * 20 / 100;
        }

        break;
}