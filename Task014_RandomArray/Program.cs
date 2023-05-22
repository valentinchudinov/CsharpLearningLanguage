// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] array = GetArray();
int evenCount = 0;
int[] GetArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int EvenCount(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            evenCount++;
    }
    return evenCount;
}

void PrintResult(int[] array, int evenCount)
{
    Console.WriteLine($"{String.Join(" ", array)}");
    Console.WriteLine($"The number of even numbers in the array is: {evenCount}");
}

EvenCount(array);
PrintResult(array, evenCount);