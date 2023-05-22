// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

static int InputArraySize(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void CreateArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(random.Next(-100, 100) + random.NextDouble(), 1);
    }
}

static void Difference(double[] array)
{
    double difference = 0;
    double maxValue = 0;
    double minValue = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
            maxValue = array[i];
        else if (array[i] < minValue)
            minValue = array[i];
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"MAX value of array is: {maxValue} and MIN value is: {minValue}");
    Console.ResetColor();

    difference = Math.Round(maxValue - minValue, 1);
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"The difference between the Maximum and Minimum values of the array is: {difference}");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Magenta;
int arraySize = InputArraySize("Enter the size of the array: ");
Console.ResetColor();

double[] array = new double[arraySize];

Console.ForegroundColor = ConsoleColor.DarkYellow;
CreateArray(array);
Console.WriteLine(string.Join(" | ", array));
Console.ResetColor();

Difference(array);