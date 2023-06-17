// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string[] array = { "X > 0 && Y > 0", "X < 0 && Y > 0", "X < 0 && Y < 0", "X > 0 && Y < 0" };


if (number > 0 && number < 5)
{
    Console.WriteLine(array[number-1]);
}
else
{
    Console.WriteLine("Такой четверти не существует");
}