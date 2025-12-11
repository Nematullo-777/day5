
static void Main(int n)
{
    string[] parts = Console.ReadLine().Split();
    int[] arr = new int[n];

    for (int i = 0; i < n; i++)
        arr[i] = int.Parse(parts[i]);

    int count = 0;

    for (int i = 1; i < n; i++)
    {
        if (arr[i] > arr[i - 1])
            count++;
    }

    Console.WriteLine(count);
}
Main(Convert.ToInt32(Console.ReadLine()));