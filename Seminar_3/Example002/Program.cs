// напишите программу, которая принимает на вход координаты 2х точек и
// находит расстояние между ними в 2D пространстве.

void Zadacha21()
{
    Console.WriteLine("Введите координату точки А: ");
    Console.WriteLine("Х: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату точки B: ");
    Console.WriteLine("Х: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Y: ");
    int by = Convert.ToInt32(Console.ReadLine());

    int k = bx - ax;
    int m = by - ay;

    double lenght = Math.Sqrt(k*k + m*m); // double потому что не толко целые числа, но и дробные
    Console.WriteLine(lenght);
    lenght = Math.Round(lenght, 2);    // Округление и сколько знаков
    Console.WriteLine($"Длинна: {lenght}");
}
Zadacha21();