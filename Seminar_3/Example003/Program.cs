// Напишите программу, которая принимает на вход число (N) и выдает
// таблицу квадратов чисел от 1 до N.

void Zadacha23()
{
    Console.WriteLine("Ведите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Число\tКвадрат");
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i,2));
    }
}
Zadacha23();