// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.Write("Input number M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Input number N: ");
int n = int.Parse(Console.ReadLine());

int sum = SumNumbers(m, n);

Console.WriteLine("Sum of numbers from {0} to {1} equal {2}", m, n, sum);

Console.ReadLine();


static int SumNumbers(int m, int n)
{
    if (m > n) 
        return 0;

    return m + SumNumbers(m + 1, n); 
}
