// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// ​
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольной


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

int SumPos(int[,] matrix)
{
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // for (int j = 0; j < matrix.GetLength(1); j++)
        // {
        //     if (i == j)
            {
                sum += matrix[i, i]; //sum+= matrix[i,j]
            }
        // }
    }
    return sum;
}

int m = ReadNumber(" Введите количество строк : ");
int n = ReadNumber(" Введите количество столбцов : ");

int[,] myMatrix = GetRandomMatrix(m, n);

PrintMatrix(myMatrix);

int sum = SumPos(myMatrix);

Console.WriteLine($" Сумма чисел на главной диагонали : {sum}");