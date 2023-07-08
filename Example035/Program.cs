// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int X)
{
    if (X == 0) return 0;
    return X % 10 + SumNumbers(X / 10);
}



int X = ReadInt("Введите число: ");
System.Console.WriteLine($" Сумма цифр введённого числа равна: {SumNumbers(X)}");