
static int Fibonacci(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static void Main(int n)
{
    Console.Write("Input number of terms for the Fibonacci series : ");

    Console.Write("The Fibonacci series of " + n + " terms is : ");

    for (int i = 0; i < n; i++)
    {
        Console.Write(Fibonacci(i) + " ");
    }

    Console.WriteLine();
}
Main(Convert.ToInt32(Console.ReadLine()));