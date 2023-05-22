// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num;
int secondNumber;

Console.Write("Enter a three digit number: ");
num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num <= 999)
{
secondNumber = (num / 10) % 10;
Console.Write("Second digit of the number is : " + secondNumber);
}
else
Console.WriteLine($"Number {num} is not digit ");
