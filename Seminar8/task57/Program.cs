// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Элементы внутри массива лежат в интервале [0, 9]


// int ReadNumber(string MessageToUser)
// {
//     Console.WriteLine(MessageToUser);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int[,] GetRandomMatrix(int rows, int columns, int leftborder = 0, int rightborder = 9)
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
// void MatrixAnalizator(int[,] matrix)
// {
//     int z1 = 0;
//     int z2 = 0;
//     int z3 = 0;
//     int z4 = 0;
//     int z5 = 0;
//     int z6 = 0;
//     int z7 = 0;
//     int z8 = 0;
//     int z9 = 0;
//     int z0 = 0;

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == 0)
//             {
//                 z1 = z1 + 1;
//             }
//             else if (matrix[i, j] == 1)
//             {
//                 z2 = z2 + 1;
//             }
//             else if (matrix[i, j] == 2)
//             {
//                 z3 = z3 + 1;
//             }
//             else if (matrix[i, j] == 3)
//             {
//                 z4 = z4 + 1;
//             }
//             else if (matrix[i, j] == 4)
//             {
//                 z5 = z5 + 1;
//             }
//             else if (matrix[i, j] == 5)
//             {
//                 z6 = z6 + 1;
//             }
//             else if (matrix[i, j] == 6)
//             {
//                 z7 = z7 + 1;
//             }
//             else if (matrix[i, j] == 7)
//             {
//                 z8 = z8 + 1;
//             }
//             else if (matrix[i, j] == 8)
//             {
//                 z9 = z9 + 1;
//             }
//             else if (matrix[i, j] == 9)
//             {
//                 z0 = z0 + 1;
//             }

//         }

//     }
//     Console.WriteLine($"Количество нулей:{z1}");
//     Console.WriteLine($"Количество единиц:{z2}");
//     Console.WriteLine($"Количество двоек:{z3}");
//     Console.WriteLine($"Количество троек:{z4}");
//     Console.WriteLine($"Количество четверок:{z5}");
//     Console.WriteLine($"Количество пятерок:{z6}");
//     Console.WriteLine($"Количество шестерок:{z7}");
//     Console.WriteLine($"Количество семерок:{z8}");
//     Console.WriteLine($"Количество восьмерок:{z9}");
//     Console.WriteLine($"Количество девяток:{z0}");
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
// int m = ReadNumber("Строки");
// int n = ReadNumber("Столбцы");
// int[,] myMatrix = GetRandomMatrix(m, n);
// PrintMatrix(myMatrix);
// Console.WriteLine();

// MatrixAnalizator(myMatrix);


int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftborder = 0, int rightborder = 9)
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

void PrintRepeats(int[,] matrix)
{
    int[] repets = new int[10];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = matrix[i, j];
            repets[matrix[i,j]]++;
        }
    }
    for (int i = 0; i < repets.Length; i++)
    {
        Console.WriteLine($"{i} повторяется {repets[i]}");
    }
}


int m = ReadNumber("Строки");
int n = ReadNumber("Столбцы");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
PrintRepeats(myMatrix);

