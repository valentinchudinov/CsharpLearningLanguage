// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int[] array = new int[8];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 10);
}

Console.WriteLine("Your array: ");
foreach (int element in array)
{
    Console.Write(element + " ");
}