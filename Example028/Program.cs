// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void UpheavalArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int buffer = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = buffer;
    }
}