
static void Main(int x,int y)
{
    for (int i = x; i <= y; i++)
    {
        Console.WriteLine(" ");
        for (int j = 1; j <= 10; j++)
        {
            Console.WriteLine($"{i}x{j}= {i * j}");
        }
    }
}
Main(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));