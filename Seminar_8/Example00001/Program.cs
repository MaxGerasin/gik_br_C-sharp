/* Задайте двумерный массив. Напишите программу, которая поменяет
 первую и последнию строки массива */

void Zadacha1()
{
    var random = new Random();
    int rows = random.Next(4, 8);
    int colomns = random.Next(4, 8);
    int[,] numbers = new int[rows, colomns];
    FillArray(numbers);
    PrintArray(numbers);
    Changer(numbers, rows);
    Console.WriteLine("Переворачиваем строки массива");
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

void Changer(int[,] numbers, int rows)
{
    int maxIndex = rows - 1;
    int maxColumns = numbers.GetLength(1);
    for (int j = 0; j < maxColumns; j++)
    {
        (numbers[0, j], numbers[maxIndex, j]) = (numbers[maxIndex, j], numbers[0, j]);
    }
}