// Написать программу вычисления значения функции  возведения числа в квадрат
// ФУНКЦИЯ !!!!

int Power(int x)
{
    return x * x;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(number));