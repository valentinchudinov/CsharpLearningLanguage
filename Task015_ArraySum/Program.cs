// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();


int sumOddIndex = 0;
int[] array = GetArray();
int[] GetArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);
    }
    return array;
}

int SumNegative(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sumOddIndex += array[i];
    }
    return sumOddIndex;
}

void PrintResult(int[] array, int sumOddIndex)
{
    Console.WriteLine($"Array: {String.Join(" ", array)}");
    Console.WriteLine($"Summary numbers of odd positions: {sumOddIndex}");
}

SumNegative(array);
PrintResult(array, sumOddIndex);