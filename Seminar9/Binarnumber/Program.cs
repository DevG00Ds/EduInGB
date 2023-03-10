



int number =13; 
PrintBinaryView(number);

void PrintBinaryView( int n)
{
    if ( n==0) return;
    PrintBinaryView(n/2);
    Console.Write(n%2);
}