// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void Main()
{
    int[] array = FillArray(5, -9, 9);
    PrintArray(array);
    // FindSumNegativeAndPositive(array, out int sumPositive, out int sumNegative);
    int sumPositive = SumArray(array);
    int sumNegative = SumArray(array, false);
    System.Console.WriteLine($"Сумма положительных чисел: {sumPositive}");
    System.Console.WriteLine($"Сумма отрицательных чисел: {sumNegative}");
}

int[] FillArray(int size = 5, int leftRange = 0, int rightRange = 20)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

void FindSumNegativeAndPositive(int[] array, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumP += array[i]; // sumPositive = sumPositive + array[i]
        }
        else
        {
            sumN += array[i];
        }
    }
}

int SumArray(int[] newArray, bool sign = true)
{
    int sum = 0;
    if (sign)
    {
        for (int i = 0; i < newArray.Length; i++)
        {
            sum += newArray[i] > 0 ? newArray[i] : 0; // Тернарный оператор
        }
    }
    else
    {
        for (int i = 0; i < newArray.Length; i++)
        {
            sum += newArray[i] < 0 ? newArray[i] : 0;
        }
    }
    return (sum);
}

Main();