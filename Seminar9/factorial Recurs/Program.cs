// Вычеслить факториал введенеого числа

// 4->24
// 5->120

uint number = 5;

uint Factorial(uint n)
{
    if (n == 0) return 1;
    if (n == 1) return 1;
    uint result = n * Factorial(n-1);
    return result;
}

Console.WriteLine(Factorial(number));
