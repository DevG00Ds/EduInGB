// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}


// {123, 234, 456, 789},
// {123, 234, 456, 789},
// {123, 234, 456, 789},
// {123, 234, 456, 789},


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

int m = ReadNumber(" Введите количество строк : ");
int n = ReadNumber(" Введите количество столбцов : ");

int[,] myMatrix = GetRandomMatrix(m, n);

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

PrintMatrix(myMatrix);