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

