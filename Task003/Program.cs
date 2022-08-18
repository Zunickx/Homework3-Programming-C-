// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое число:");
string num = Console.ReadLine()!;

for (int i = 1; i <= int.Parse(num); i++)
{
    Console.WriteLine(i + "^3 = " + Math.Pow(i, 3));
}