
static int EvenCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        int d = n % 10;
        if (d % 2 == 0) count++;
        n /= 10;
    }
    return count;
}

static int OddCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        int d = n % 10;
        if (d % 2 != 0) count++;
        n /= 10;
    }
    return count;
}

static int ZeroCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        int d = n % 10;
        if (d == 0) count++;
        n /= 10;
    }
    return count;
}

static int DigitCount(int n)
{
    int count = 0;
    while (n > 0)
    {
        count++;
        n /= 10;
    }
    return count;
}

static int MinDigit(int n)
{
    int min = 9;
    while (n > 0)
    {
        int d = n % 10;
        if (d < min) min = d;
        n /= 10;
    }
    return min;
}

static int MaxDigit(int n)
{
    int max = 0;
    while (n > 0)
    {
        int d = n % 10;
        if (d > max) max = d;
        n /= 10;
    }
    return max;
}

static int SumDigit(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

static void Main(int n)
{
    Console.WriteLine("Even : " + EvenCount(n));
    Console.WriteLine("Odd : " + OddCount(n));
    Console.WriteLine("Zeros : " + ZeroCount(n));
    Console.WriteLine("Digits : " + DigitCount(n));
    Console.WriteLine("Min : " + MinDigit(n));
    Console.WriteLine("Max : " + MaxDigit(n));
    Console.WriteLine("Sum of Digits : " + SumDigit(n));
    return ;
}
Main(Convert.ToInt32(Console.ReadLine()));