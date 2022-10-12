/* Задайте двумерный массив размеров m x n, заполненный случайными целыми числами  */

void Zadacha1()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 9);
    Console.WriteLine($"Массив размера {rows}x{columns}");

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
}
Zadacha1();

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

