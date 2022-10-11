/* Не использывая рекурсию, выведите первые N чиисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1. */

void Zadacha4()
{
    Console.WriteLine("Введите N числа Фибоначчи ");
    int size = Convert.ToInt32(Console.ReadLine());
    int a = 0;
    int b = 1;
    int[] numbers = new int[size];
    numbers[0] = a;
    numbers[1] = b;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }
    PrintArray(numbers);
}
Zadacha4();

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(" " + numbers[i]);
    }
    Console.WriteLine();
}

