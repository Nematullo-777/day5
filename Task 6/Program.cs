static double Sum(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiplication(double a, double b)
{
    return a * b;
}

static double Division(double a, double b)
{
    return a / b;
}


static void Main(double num1,char op,double num2)
{
    Console.Write("The first number is: ");

    Console.Write("The operation is: ");

    Console.Write("The second number is: ");

    double result = 0;

    if (op == '+')
        result = Sum(num1, num2);
    else if (op == '-')
        result = Subtract(num1, num2);
    else if (op == '*')
        result = Multiplication(num1, num2);
    else if (op == '/')
        result = Division(num1, num2);
    else
    {
        Console.WriteLine("Invalid operation!");
        return;
    }

    Console.WriteLine($"{num1} {op} {num2} = {result}");
}
Main(Convert.ToDouble(Console.ReadLine()),Convert.ToChar(Console.ReadLine()),Convert.ToDouble(Console.ReadLine()));