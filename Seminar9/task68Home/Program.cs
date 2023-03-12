// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int ReadNumber(string MessageToUser)
{
    Console.Write(MessageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int m = ReadNumber(" Введите M : ");
int n = ReadNumber(" Введите N : ");

AkermanPrint(m,n);

int Akerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Akerman(m - 1, 1);
    }
    else
    {
        return (Akerman(m - 1, Akerman(m, n - 1)));
    }
}

void AkermanPrint( int m, int n)
{
    Console.WriteLine($"Число Акермана равно {Akerman(m,n)}");
}