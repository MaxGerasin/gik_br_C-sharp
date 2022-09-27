/* Напишите программу, которая принимает на вход 2 числа  и проверяет,
   является ли одно число квадратом другого */

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 = num1 * num1 || num1 = num2 * num2)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}