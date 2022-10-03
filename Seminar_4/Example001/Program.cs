// напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до А.

void Zadacha1()
{
    int number = 5;
    int sum = 0;

    for (int i = 1; i <=number; i++)
    {
        sum +=i;
    }
    Console.WriteLine($"{sum}");
}
Zadacha1();