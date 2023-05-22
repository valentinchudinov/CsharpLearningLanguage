// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int[,] array = CreateArray();
PrintArray(array);

static int[,] CreateArray()
{
    int[,] array = new int[4, 4];
    int num = 1; 
    int rowStart = 0; 
    int rowEnd = array.GetLength(0) - 1; 
    int colStart = 0; 
    int colEnd = array.GetLength(1) - 1; 

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = num;
            num++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = num;
            num++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        { 
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = num;
                num++;
            }
            rowEnd--;
        }
       
        if (colStart <= colEnd)
        { 
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = num;
                num++;
            }
            colStart++;
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
            Console.Write($"{array[i, j],-3}");
        }
        Console.WriteLine();
    }
}
