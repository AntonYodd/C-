// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void Main()
{
    int[] array = FillArray(7, 0, 10);
    PrintArray(array);
    int[] result = MultElements(array);
    PrintArray(result);
}

int[] MultElements(int[] inputArray)
{
    int[] result = new int[inputArray.Length / 2 + inputArray.Length % 2];
    for (int i = 0; i < inputArray.Length / 2; i++)
    {
        result[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
    }

    if (inputArray.Length % 2 == 1)
    {
        result[result.Length - 1] = inputArray[inputArray.Length / 2];
    }
    return result;
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

Main();
