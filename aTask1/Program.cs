Console.Write("\nВведите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
int temp = M;

if (M > N) 
{
  M = N; 
  N = temp;
}

PrintSum (M, N, temp = 0);

void PrintSum (int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {sum} ");
    Console.WriteLine();
    return;
  }
  PrintSum(m, n - 1, sum);
}


