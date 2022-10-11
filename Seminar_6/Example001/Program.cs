/* Напишите программу, которая перевернет одномерный массив
(последний элемент будет на первом, а первый на последним) */

void Zadacha1()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    ReverseArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[] numbers,
               int minValue = 0,
               int maxValue = 9)
{
    maxValue++;
    int size = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] numbers)
{
    int size = numbers.Length;
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        /*    int temp = numbers[i];
           numbers[i] = numbers[maxIndex - i];
           numbers[maxIndex - i] = temp; */
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
}
Zadacha1();