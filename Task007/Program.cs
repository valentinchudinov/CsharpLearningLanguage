//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("\nPlease enter a number that corresponds to a day of the week (1-7): ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 6)
    Console.ForegroundColor = ConsoleColor.Yellow;
else if (day == 6 || day == 7)
    Console.ForegroundColor = ConsoleColor.Green;
else
    Console.ForegroundColor = ConsoleColor.Red;

switch (day)
{
    case 1:
        Console.WriteLine("Tuesday is not a holiday");
        break;
    case 2:
        Console.WriteLine("Tuesday is not a holiday");
        break;
    case 3:
        Console.WriteLine("Tuesday is not a holiday");
        break;
    case 4:
        Console.WriteLine("Tuesday is not a holiday");
        break;
    case 5:
        Console.WriteLine("Tuesday is not a holiday");
        break;
    case 6:
        Console.WriteLine("Tuesday is a holiday");
        break;
    case 7:
        Console.WriteLine("Tuesday is a holiday");
        break;
    default:
        Console.WriteLine("Invalid number");
        break;
}

Console.ResetColor();