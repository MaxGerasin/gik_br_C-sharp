/* Напишите программу которая принимает на вход число и
   проверяет кратно оно одновренменно 7 и 23. */

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb % 7 == 0 && numb % 23 == 0)
{
    Console.WriteLine($"Число {numb} кратно");
}
else
{
    Console.WriteLine($"Число {numb} не кратно");
}