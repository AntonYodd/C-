//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int ReadInt()
{
    System.Console.WriteLine("Enter a:");
    return Convert.ToInt32(System.Console.ReadLine());
}

void NumberToBinary(int number)
{
    if (number == 0)
    {
        return;
    }
    NumberToBinary(number / 2);
    System.Console.Write(number % 2);
}

Console.Clear();
int a = ReadInt();
NumberToBinary(a);