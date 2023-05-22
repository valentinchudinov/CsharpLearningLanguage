
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.

Console.Clear();

int[] size = GetArraySize();
int[,] array = FillArray(size[0], size[1]);

PrintArray(array);
int minSumRowIndex = FindMinSumRow(array);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("The row with the smallest sum of elements:");
PrintRow(array, minSumRowIndex);

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

static int[,] FillArray(int rows, int cols)
{
    Random rand = new Random();
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 10);
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
            Console.Write("{0,10}", array[i, j]);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

 static int FindMinSumRow(int[,] array) {
    int minSumRowIndex = 0;
    int minSumRowSum = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++) {
      int rowSum = 0;
      for (int j = 0; j < array.GetLength(1); j++) {
        rowSum += array[i,j];
      }
      if (rowSum < minSumRowSum) {
        minSumRowSum = rowSum;
        minSumRowIndex = i;
      }
    }
    return minSumRowIndex;
  }

 static void PrintRow(int[,] array, int rowIndex) {
    for (int j = 0; j < array.GetLength(1); j++) {
      Console.Write(array[rowIndex, j] + " ");
    }
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("(Row number: " + rowIndex + ")");
  }


Console.ResetColor();
