// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Numbers(int N)
{
    if (N == 0) return;
    Numbers(N - 1);
    System.Console.Write(N + " ");

}

int N = ReadInt("Введите число");
Numbers(N);