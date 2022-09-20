// Написать программу, которая на вох принимает 2 числа
// и проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}