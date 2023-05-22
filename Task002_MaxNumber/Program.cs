/* 
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int result = Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber);
Console.WriteLine($"The largest number is: {result}");