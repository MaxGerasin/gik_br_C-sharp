/* Здайте двумерный массив. Найдите сумму элементов, находящихся на главной
диагонали (с индексами (0, 0) (1, 1) и т.д.) */

void Zadacha4()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 9);
    Console.WriteLine($"Массив размера {rows}x{columns}");

    int[,] numbers = new int[rows, columns];
    int sum = 0;
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum = sum + numbers[i, j];
            }
        }
    }
    Console.WriteLine($"Сумма элементов на главное диогонали:  {sum}");
}
Zadacha4();

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 10);
        }
    }
}


void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
