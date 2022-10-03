// напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1
// в случайном порядке

void Zadacha4()
{
    Random random = new Random();
    int size = random.Next(4, 10);
    int[] numbers = new int[size];
    Console.WriteLine(size);

    FillArray(numbers);
    /*for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine($"Введите {i +1}-й элемент массива ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    } */
    PrintArray(numbers);
}

void FillArray(int[] num)                            // Метод для заполнения массива
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(0, 2);
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

Zadacha4();