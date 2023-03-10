// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Clear();

int number = 453;


int SummaDigits(int n)
{
    int sum = 0;
    if (n == 0) return 0;
    else
    {
        sum += n % 10+ SummaDigits(n/10);
    }
    return sum;
}

Console.WriteLine(SummaDigits(number));