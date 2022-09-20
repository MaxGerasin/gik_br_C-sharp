// Написать программу, которая на вход принимает одно чило (N),
// а на выходе показывает все целые числа в промежутке от -N до N

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);   // Вводит Абсолютное число, чтобы работало и с минусовыми числами
int num2 = -num;
while(num2 <= num)
{
    Console.Write(num2 + ",");
    num2 = num2 + 1;
}
Console.WriteLine();