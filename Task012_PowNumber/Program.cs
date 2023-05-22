// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();

Console.WriteLine("Enter first number :");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number :");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = 1;

if (secondNumber < 0)
        secondNumber *= -1;

else if (secondNumber == 0)
    secondNumber = 1;


for (int i = 0; i < secondNumber; i++)
{
    result *= firstNumber;
}

Console.WriteLine($"First number in power of second number equal {result}");
