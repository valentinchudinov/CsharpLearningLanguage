// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number\tCube");
for (int i = 1; i <= n; i++)
{
    int cube = Convert.ToInt32(Math.Pow(i, 3));
    Console.WriteLine("{0}\t{1}", i, cube);
}