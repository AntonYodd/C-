//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
//Например, изначально массив
//выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть 
//вот так:
//1 4 7 2
//5 81 2 9
//8 4 2 4

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void NewPrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            if (i%2 == 1 && j%2 == 1)
            {
                matrixForPrint[i,j] = (int)Math.Pow(matrixForPrint[i, j], 2);
            }
        }
    }
}

// -----------------

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Ведите количество стобцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 100);
PrintMatrix(matrix);
NewPrintMatrix(matrix);
System.Console.WriteLine(" ");
PrintMatrix(matrix);