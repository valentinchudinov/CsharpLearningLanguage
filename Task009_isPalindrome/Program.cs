// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Enter five-digit number :");
int inputNumber = Convert.ToInt32(Console.ReadLine());

bool isPalindrome = true;

if (inputNumber > 9999 && inputNumber < 100000)
{
    string inputNumberAsString = inputNumber.ToString();
    for (int i = 0; i < 5; i++)
    {
        if (inputNumberAsString[i] != inputNumberAsString[4 - i])
        {
            isPalindrome = false;
            break;
        }
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"The entered number {inputNumber} is a five-digit palindrome");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"The entered number {inputNumber} is NOT a five-digit palindrome");
    Console.ResetColor();
}



