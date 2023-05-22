//  Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Enter the number of rows: ");
int n = int.Parse(Console.ReadLine());
Console.Clear();

int[,] array = CreateArray(n);
PrintArray(array);

static int[,] CreateArray(int n)
{
    int[,] array = new int[n, n * 2 - 1];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n * 2 - 1; j++)
        {
            if (j == n - 1 || j == n * 2 - 2 - i)
            {
                array[i, j] = 1;
            }
            else if (j > n - 1 - i && j < n + i - 1)
            {
                array[i, j] = array[i - 1, j - 1] + array[i - 1, j + 1];
            }
        }
    }

    return array;
}

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array[i, j],-3}");
                Console.ResetColor();
            }
            else
            {
                Console.Write("   ");
            }
        }
        Console.WriteLine();
    }
}
