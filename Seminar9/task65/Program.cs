// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"

int m = 4;
int n = 8;

void NaturalNumber( int min, int max)
{
    if ( max == min-1) return;
    else
    {
        NaturalNumber(min, max-1);
        Console.Write(max + " ");   
    }
}

NaturalNumber(m,n);