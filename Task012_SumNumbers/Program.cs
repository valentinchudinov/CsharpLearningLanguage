// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

Console.WriteLine("Enter number :");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (number < 0)
        number *= -1;

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine("The sum of the digits in a number: " + sum);