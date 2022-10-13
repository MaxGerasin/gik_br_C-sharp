void Zadacha1()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int colomns = random.Next(4, 8);
    int[,] numbers = new int[rows, colomns];
    FillArray(numbers);
    PrintArray(numbers);

    int min_i = 0;
    int max_i = rows - 1;

    for (int j = 0; j < colomns; j++)
    {
        (numbers[min_i, j], numbers[max_i, j]) = (numbers[max_i, j], numbers[min_i, j]);
    }
    Console.WriteLine();
    PrintArray(numbers);
}
Zadacha1();


void FillArray(int[,] numbers)
{
    Random random = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = random.Next(-10, 10);
        }
    }
}


void PrintArray(int[,] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
