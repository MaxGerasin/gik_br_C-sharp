/* Задайте двумерный массив размеров m на n, каждый элемент массива находиться по
формуле: A = i+j. Вывести полученный массив на экран */

void Zadacha2()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 9);
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,] numbers = new int[rows, columns];
    FillArrayIndexSum(numbers);
    PrintArray(numbers);
}
Zadacha2();


void FillArrayIndexSum(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
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
