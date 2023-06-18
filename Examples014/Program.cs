// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int CountNumbers(int N)
{
    int count = 0;

    if (N == 0)
    {
        return 1;
    }

    while (N > 0)
    {
        N /= 10; // number = number / 10
        count++;
    }

    return count;
}

// -----------------------------------------------------------------------

int count = CountNumbers(ReadInt("Введите число: "));
System.Console.WriteLine($"Количество цифр в числе -> {count}");