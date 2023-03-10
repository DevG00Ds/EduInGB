



int number = 5;

void MethodRec(int n)
{
    if (n == 0) return;
    else
    {
        MethodRec(n - 1);
        Console.Write(n + " ");
    }
}

MethodRec(number);