//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

Console.Write("Enter numbers separated by spaces: ");
string input = Console.ReadLine();

int[] numbers = ParseInput(input);
int count = CountPositive(numbers);

Console.WriteLine($"Number of positive numbers: {count}");
Console.Write("Positive numbers: ");
PrintPositive(numbers);
    

    static int[] ParseInput(string input) // разбивает строку ввода на отдельные числа и сохраняет их в массив.
{  
    string[] parts = input.Split(' ');
    int[] numbers = new int[parts.Length];
    for (int i = 0; i < parts.Length; i++)
    {
        numbers[i] = int.Parse(parts[i]);
    }
    return numbers;
}

static int CountPositive(int[] numbers) // считает количество положительных чисел в массиве. 
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)        
            count++;       
    }
    return count;
}

static void PrintPositive(int[] numbers) // выводит на экран все положительные числа из массива.
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)        
            Console.Write(numbers[i] + " ");        
    }
}