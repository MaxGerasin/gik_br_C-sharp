// Задайте массив из 12 элементов, заполненный случайными числами в промежутке [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

void Zadacha1()
{
int size = 12;
int[] numbers = new int[size];
FillArray(numbers, -9, 9);
PrintArray(numbers);
GetSummNegative(numbers);
GetSummPositive(numbers);
Console.WriteLine(GetSummNegative(numbers));
Console.WriteLine(GetSummPositive(numbers));
}

int GetSummPositive(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            sum += numbers[i];
    }
    return sum;
}

int GetSummNegative(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0)
            sum += numbers[i];
    }
    return sum;
}

void FillArray(int[] numbers,
                int minValue,
                int maxValue)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "   ");
    }
    Console.WriteLine();
}
Zadacha1();