//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Input number N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(n);

Console.ReadLine();


static void PrintNumbers(int n)
{
    if (n == 0) 
        return;

    Console.Write(n + " "); 

    PrintNumbers(n - 1); 
}
