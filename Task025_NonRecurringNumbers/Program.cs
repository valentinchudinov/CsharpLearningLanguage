// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

Console.Clear();



int[,,] array = CreateArray();
PrintArray(array);


static int[,,] CreateArray()
{
    int[,,] array = new int[2, 2, 2];
    Random rnd = new Random();
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                int num;
                do
                {
                    num = rnd.Next(10, 100); 
                } 
                while (ArrayContains(array, num)); 
                array[i, j, k] = num;
            }
        }
    }
    return array;
}

static bool ArrayContains(int[,,] array, int num)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                if (array[i, j, k] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

static void PrintArray(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"array[{i},{j},{k}] = {array[i, j, k]}");
                Console.ResetColor();
            }
        }
    }
}
