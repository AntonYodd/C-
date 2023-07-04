// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void FreqDictionary(int[,] array)
{
    // int[] countArray = new int[10];
    int max = array.Cast<int>().Max();
    int[] countArray = new int[max+1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // for (int k = 0; k < countArray.Length; k++)
            //     if (k == array[i, j])
            //     {
            //         countArray[k]++;
            //     }
            countArray[array[i,j]]++;
        }
    }

    for (int k = 0; k < countArray.Length; k++)
    {
        if (countArray[k] != 0) Console.WriteLine($"Число {k} в массиве встречается {countArray[k]}");
    }
}


  