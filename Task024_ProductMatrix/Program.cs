// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();



int[,] array1 = CreateArray();
int[,] array2 = CreateArray();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("First matrix:");
PrintArray(array1);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Second matrix:");
PrintArray(array2);

int[,] result = MultiplyArrays(array1, array2);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Result of matrix multiplication:");
PrintArray(result);


static int[,] CreateArray()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Enter the number of rows and columns separated by a space: ");
    string[] input = Console.ReadLine().Split();
    int rows = int.Parse(input[0]);
    int columns = int.Parse(input[1]);
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        throw new ArgumentException("The number of columns of the first matrix must be equal to the number of rows of the second matrix");
        Console.ResetColor();
    }
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}

Console.ResetColor();