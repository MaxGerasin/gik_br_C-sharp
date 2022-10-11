/* Напишите программу, которая будет создавать копию заданного массива
с помощью по элементного копирования */

void Zadacha5()
{
    int size = 10;
    int[] numbers = new int[size];
    int[] other = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        other[i] = numbers[i];
    }
    PrintArray(other);
}
Zadacha5();

void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 10);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(" " + numbers[i]);
    }
    Console.WriteLine();
}