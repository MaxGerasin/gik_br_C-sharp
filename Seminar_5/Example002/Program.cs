// Напишите программу замены элементов массива: положительные заменить на соотвествующие отрицательные,
// и наоборот.
void Zadacha2()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    ChangeValue(numbers);
    PrintArray(numbers);
}

Zadacha2();

void ChangeValue(int[] numbers)                // Меняет знаки
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }

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

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + ",   ");
    }
    Console.Write("\b\b\b");
    Console.WriteLine();
}
