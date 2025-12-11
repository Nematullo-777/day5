
static void Main(int N)
{
    string[] parts = Console.ReadLine().Split();
    int[] arr = new int[N];

    for (int i = 0; i < N; i++)
    {
        arr[i] = int.Parse(parts[i]);
    }

    Console.WriteLine();

    for (int i = 0; i < N; i++)
    {
        for (int j = i + 1; j < N; j++)
        {
            if (arr[i] == arr[j])
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
Main(Convert.ToInt32(Console.ReadLine()));