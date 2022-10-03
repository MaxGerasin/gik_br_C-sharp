// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

void Zadacha2()
{
    int number = 123323;
    int current = number;
    int count = 0;

    while (current > 0)
    {
        current = current / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе {number} = {count}");
}
Zadacha2();

