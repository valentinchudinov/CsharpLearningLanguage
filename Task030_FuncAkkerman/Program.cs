// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

Console.Write("Input number m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Input number n: ");
int n = int.Parse(Console.ReadLine());

int result = Ackermann(m, n);

Console.WriteLine("Result of the Ackermann function for numbers {0} и {1} equal {2}", m, n, result);

static int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0) 
        return Ackermann(m - 1, 1);
    else 
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
