// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int A)
{
    int sum = 0;

    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }

    return sum;
}

//------------------------------------------------------------------

int number = ReadInt("Введите число: ");
int sum = SumNumbers(number);

System.Console.WriteLine($"Сумма числе от 1 до {number}: {sum}");