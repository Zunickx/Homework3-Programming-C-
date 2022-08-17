// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координату x первой точки:");
string x = Console.ReadLine()!;
int xCoordinate = int.Parse(x);
Console.WriteLine("Введите координату y первой точки:");
string y = Console.ReadLine()!;
int yCoordinate = int.Parse(y);
Console.WriteLine("Введите координату z первой точки:");
string z = Console.ReadLine()!;
int zCoordinate = int.Parse(z);
Console.WriteLine("Введите координату x второй точки:");
string x1 = Console.ReadLine()!;
int x1Coordinate = int.Parse(x1);
Console.WriteLine("Введите координату y второй точки:");
string y1 = Console.ReadLine()!;
int y1Coordinate = int.Parse(y1);
Console.WriteLine("Введите координату z второй точки:");
string z1 = Console.ReadLine()!;
int z1Coordinate = int.Parse(z1);

double result = Math.Pow((x1Coordinate - xCoordinate), 2) + Math.Pow((y1Coordinate - yCoordinate), 2) + Math.Pow((z1Coordinate - zCoordinate), 2);

double segmentLength = Math. Sqrt(result);

Console.WriteLine(segmentLength);