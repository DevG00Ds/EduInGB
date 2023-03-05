// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int RightRange = 10)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftRange, RightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber(" Введите количество строк : ");
int n = ReadNumber(" Введите количество столбцов : ");

int[,] myMatrix = GetRandomMatrix(m, n);

PrintMatrix(myMatrix);

for (int i = 0; i < myMatrix.GetLength(1); i++)
{
    double averageNumber = 0;

    for (int j = 0; j < myMatrix.GetLength(0); j++)
    {
        averageNumber = (averageNumber + myMatrix[j, i]);
    }
    averageNumber = averageNumber / m;
    
    Console.Write(averageNumber + "; ");
}


