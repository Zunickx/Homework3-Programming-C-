//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число:");
string num = Console.ReadLine()!;
string numReverse = num; // примитивный тип копируется не по ссылке, а по значению

char[] reverseNumArr = numReverse.ToCharArray(); // преобразовали строку к массиву символов
Array.Reverse(reverseNumArr);
numReverse = new string(reverseNumArr);

if(num == numReverse)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}
