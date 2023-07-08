// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Power(int X, int Y)
{
    if (Y == 0) return 1;
    return X * Power(X, Y - 1);
}



int X = ReadInt("Введите число: ");
int Y = ReadInt("Введите число: ");
System.Console.WriteLine($"Число {X} в степени {Y}: {Power(X, Y)}");