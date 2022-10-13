/* Задайте двумерный массив. Напишите программу, которая заманяет строки на столбцы
В Случае, если это невозможно, программа должна вывести сообщение для пользователя. */

void Zadacha2()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int columns = rows;
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Строк: {rows}, Столбцов: {columns}");
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            int temp = numbers[i, j];
            numbers[i, j] = numbers[j, i];
            numbers[j, i] = temp;
        }
    }
    Console.WriteLine();
    PrintArray(numbers);
}
Zadacha2();


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