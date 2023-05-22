// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();



int[] size = GetArraySize();
double[,] array = FillArray(size[0], size[1]);

static int[] GetArraySize()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter the dimensions of the two-dimensional array separated by spaces: ");
    string[] input = Console.ReadLine().Split(' ');

    int[] size = new int[2];
    size[0] = int.Parse(input[0]);
    size[1] = int.Parse(input[1]);

    return size;
}

static double[,] FillArray(int rows, int cols)
{
    Random rand = new Random();
    double[,] array = new double[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 1);
        }
    }
    return array;
}
    
static void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0,10}", array[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

static void SortArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    double temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Source array:");
PrintArray(array);
SortArray(array);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Sort array:");
PrintArray(array);

Console.ResetColor();