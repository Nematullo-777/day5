
static double Power(double baseValue, int exponent)
{
    if (exponent == 0)
        return 1;
    else if (exponent > 0)
        return baseValue * Power(baseValue, exponent - 1);
    else
        return 1 / Power(baseValue, -exponent);
}

static void Main(double baseValue,int exponent)
{
    double result = Power(baseValue, exponent);

    Console.WriteLine($"The value of {baseValue} to the power of {exponent} is : {result}");
}
Main(Convert.ToDouble(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));