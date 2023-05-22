 /* 
 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/

Console.WriteLine("Enter first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber>secondNumber)
    Console.WriteLine($"number {firstNumber} is greater than {secondNumber} is less");
else
    Console.WriteLine($"number {secondNumber} is greater than {firstNumber} is less");

