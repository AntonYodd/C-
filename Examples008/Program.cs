//  Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int[] coordinates = new int[2];

Console.Write("Введите координату Х: ");
coordinates[0] = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
coordinates[1] = Convert.ToInt32(Console.ReadLine());

if (coordinates[0] > 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Точка находится в 1-й четверти");
}
else if (coordinates[0] < 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Точка находится во 2-й четверти");
}
else if (coordinates[0] < 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Точка находится в 3-й четверти");
}
else if (coordinates[0] > 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Точка находится во 4-й четверти");
}
else
{
    System.Console.WriteLine("Введены неправильные координаты");
}