// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// // В случае, если это невозможно, программа должна вывести сообщение для пользователя.



// int ReadNumber(string MessageToUser)
// {
//     Console.WriteLine(MessageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int[,] GetRandomMatrix(int rows, int columns, int leftborder = 0, int rightborder = 10)
// {
//     int[,] matrix = new int[rows, columns];


//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = Random.Shared.Next(leftborder, rightborder + 1);

//         }

//     }
//     return matrix;
// }

// void MatrixSwitch(int[,] matrix)
// {
//     int i = matrix.GetLength(0) - 1;
//     int temp = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         temp = matrix[0, j];
//         matrix[0, j] = matrix[i, j];
//         matrix[i, j] = temp;

//     }

// }

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

// int [,] TransposeMatrix(int [,] sourseMatrix)
// {
//     int [,] newMatrix = new int [sourseMatrix.GetLength(1),sourseMatrix.GetLength(0)];
//     for ( int i = 0; i< newMatrix.GetLength(0); i++)
//     {
//         for ( int j = 0; j< newMatrix.GetLength(1); j++)
//         {
//             newMatrix[i,j] = sourseMatrix[j,i];
//         }
//     }
//     return newMatrix;
// }
// int m = ReadNumber("Строки");
// int n = ReadNumber("Столбцы");
// int[,] myMatrix = GetRandomMatrix(m, n);
// PrintMatrix(myMatrix);
// Console.WriteLine();

// int [,] myMatrix2 = TransposeMatrix(myMatrix);
// PrintMatrix(myMatrix2);


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
int [,] Trans(int[,]matrix)
{
    int [,] newMatrix = new int [matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j,i]=matrix[i,j];
        }
}
return newMatrix;
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

int[,]mytrans=Trans(myMatrix);
PrintMatrix(mytrans);
Console.WriteLine();