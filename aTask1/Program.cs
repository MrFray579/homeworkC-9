Console.Write("\nВведите M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < N; i++)
{
    if (M < N)
    Console.Write((M++) + ", ");
    else
    Console.Write((M++) + ". ");
}
Console.WriteLine();
