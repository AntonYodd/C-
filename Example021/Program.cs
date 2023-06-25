// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


void Main()
{
    int[] array = FillArray(7, 0, 10);  // Сгенерировали массив
    PrintArray(array);                  // Вывели исходный массив
    ReverseArray(array);                // Развернули массив при помощи нашей функции
    PrintArray(array);                  // Вывели массив
    Array.Reverse(array);               // Развернули массив при помощи встроенной функции
    PrintArray(array);                  // Вывели массив
}

void ReverseArray(int[] arrayToReverse)
{
    // Создали временную переменную для хранения промежуточных значений
    int temp = 0; 
    
    // Запустили цикл, который проходит по нашему массиву (количество итераций равно половине длины массива)
    for (int i = 0; i < arrayToReverse.Length / 2; i++)
    {
        // Сохранили в временную переменную значение, которое стояло в начале массива (для того, чтобы оно не потерялось)
        temp = arrayToReverse[i]; 

        // Поменяли значение элемента массива, которое стояло в начале, на значение, которое стояло в конце
        arrayToReverse[i] = arrayToReverse[arrayToReverse.Length - 1 - i]; 

        // Поменяли значение элемента массива, которое стояло в конце, на значение, которое хранилось во временной переменной
        arrayToReverse[arrayToReverse.Length - 1 - i] = temp; 
    }
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


