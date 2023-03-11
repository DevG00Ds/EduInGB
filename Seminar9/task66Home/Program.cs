// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int ReadNumber(string MessageToUser)
{
    Console.Write(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int m = ReadNumber(" M : ");
int n = ReadNumber(" N : ");

int SummaMN(int m, int n)
{
    int result = m;
    if (m == n) return 0;
    else
    {
        m++;
        result = m + SummaMN(m, n);

    }
    return result;
}

SummaMN(m, n);

void SumFromMToN(int m, int n)
{
    Console.Write(SummaMN(m-1, n));
}

Console.WriteLine("Сумма значений в промежутке");
SumFromMToN( m, n);