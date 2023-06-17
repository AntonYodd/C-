// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int[] aCoordinate = new int[2];
Console.WriteLine("Введите x первой точки: ");
aCoordinate[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки: ");
aCoordinate[1] = Convert.ToInt32(Console.ReadLine());
int[] bCoordinate = new int[2];
Console.WriteLine("Введите x первой точки: ");
bCoordinate[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки: ");
bCoordinate[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bCoordinate[0] - aCoordinate[0]), 2) + Math.Pow((bCoordinate[1] - aCoordinate[1]), 2)), 3));