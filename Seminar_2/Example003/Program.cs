/* Напишите программу которая будет принимать на вход 2 числа и 
   выводить является ли второе число кратное первому.Если число 2
   не кратно числу 1, то программа выводит остаток от деления. */

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 % num1 == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine($"Остаток от деления = {num2 % num1}");
}