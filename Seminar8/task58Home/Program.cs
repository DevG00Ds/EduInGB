// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49



Console.Clear();

int ReadNumber(string MessageToUser)
{
    Console.Write(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int m = ReadNumber("Введите число сток 1-матрицы : ");
int n = ReadNumber("Введите число столбцов 1-матрицы и число строкк 2-матрицы : ");
int p = ReadNumber("Введите число строк 2-матрицы : ");



int[,] GetRandomMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
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

void ResultBothMatrix(int[,] firstmatrix, int[,] secondMatrix, int[,] resBothMatrix)
{
    for (int i = 0; i < resBothMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resBothMatrix.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < firstmatrix.GetLength(1); k++)
            {
                sum += firstmatrix[i,k] * secondMatrix[k,j];
            }
            resBothMatrix[i, j] = sum;
        }
    }
}

int[,] firstMatrix = new int[m, n];
GetRandomMatrix(firstMatrix);
Console.WriteLine("Первая матрица");
PrintMatrix(firstMatrix);

int[,] secondMatrix = new int[n, p];
GetRandomMatrix(secondMatrix);
Console.WriteLine("Вторая матрица");
PrintMatrix(secondMatrix);

int[,] resBothMatrix = new int[m, p];
ResultBothMatrix(firstMatrix, secondMatrix, resBothMatrix);
Console.WriteLine("Произвидение 2 Матриц");
PrintMatrix(resBothMatrix);
