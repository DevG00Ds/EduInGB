// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет



int ReadNumber(string messageToUser)
{
    Console.Write(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = new int[10, 10];

int[,] GetRandomMatrix(int[,] array)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) / 10;

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

int m = ReadNumber(" Введите номер на строке : ");
int n = ReadNumber(" Введите намер на столбце : ");

GetRandomMatrix(matrix);
PrintMatrix(matrix);

if (m > matrix.GetLength(0) || n > matrix.GetLength(1))
{
    Console.WriteLine("Такого номера нет");
}
else
{
    Console.WriteLine($"Значение номера {m} строке и {n} в столбце равен {matrix[m - 1, n - 1]}");
}