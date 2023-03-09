// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


Console.Clear();

int ReadNumber(string MessageToUser)
{
    Console.WriteLine(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int x = ReadNumber("Введите кардинату X :");
int y = ReadNumber("Введите кардинату Y :");
int z = ReadNumber("Введите кардинату Z : ");

void GetMatrix(int [,,] array3D)
{
    int[,,] matrix3D = new int [x,y,z];
    
    for ( int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j< array3D.GetLength(1); j++)
        {
            Console.Write($" X ({i}) Y ({j})");
            
            for ( int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($" Z ({k})={array3D[i,j,k]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
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

PrintMatrix();