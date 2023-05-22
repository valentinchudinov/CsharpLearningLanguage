//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number > 99 ? number.ToString()[2] : $"There is no third digit in this number '{number}' ");