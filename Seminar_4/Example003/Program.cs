// Напишите программу, которая принимает на вход число N и выдает произведение 
// чисел от 1 до N. (т.е. Факториал)

void Zadacha3()
{
    int number = 5;
    int result = 1;

    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    Console.WriteLine($"Произведение чисел = {result}");
}
//Zadacha3();

void Zadacha3_2()
{
    Console.WriteLine("\n \t Task3");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int factorial = 1;

    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    Console.WriteLine($"{num} --> {factorial}");
}
Zadacha3_2();