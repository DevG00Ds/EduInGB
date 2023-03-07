// // Задача 53:
// // Задайте двумерный массив.
// // Напишите программу, которая поменяет местами первую и последнюю строку массива.


// int ReadNumber(string messageToUser)
// {
//     Console.Write(messageToUser);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GetRandomMatrix(int rows, int columns, int leftRange = 0, int RightRange = 10)
// {
//     int[,] matrix = new int[rows, columns];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Random.Shared.Next(leftRange, RightRange + 1);
//         }
//     }
//     return matrix;
// }

// int m = ReadNumber(" Введите количество строк : ");
// int n = ReadNumber(" Введите количество столбцов : ");

// int[,] myMatrix = GetRandomMatrix(m, n);

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// PrintMatrix(myMatrix);

// void ReverseLine(int[,] matrix)
// {
//     int i = matrix.GetLength(0) -1;
//     int temp = 0;
 
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             temp = matrix[0,j];
//             matrix[0,j]=matrix[i,j];
//             matrix[0,j] = temp;
//         }
    
//     Console.WriteLine();
// }

// ReverseLine(myMatrix);
// PrintMatrix(myMatrix);

// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftborder = 0, int rightborder = 10)
{
    int[,] matrix = new int[rows, columns];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftborder, rightborder + 1);

        }

    }
    return matrix;
}
void MatrixSwitch(int[,] matrix)
{
  int i = matrix.GetLength(0) - 1;
  int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp = matrix[0,j];
                matrix[0,j] = matrix[i,j];
                matrix[i,j] = temp;

            }
            
    
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
int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine();

MatrixSwitch(myMatrix);
PrintMatrix(myMatrix);