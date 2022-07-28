Console.Write("\nВведите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Recursion(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    } 
    else if (n == 0 && m > 0) 
    {
        return Recursion(m - 1, 1);
    } 
    else 
    {
        return Recursion(m - 1, Recursion(m, n - 1));
    }
}

Console.WriteLine(Recursion(M, N));


