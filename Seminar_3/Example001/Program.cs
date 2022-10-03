//Напишите программу, которая принимает на вход координаты точки (X, Y),
//приечем X и Y не равны 0 и выдает номер четверти плоскости, в которой находиться эта точка

void Zadacha17()
{
    Random rand = new Random(); // создаем переменнюу рандом
    int x = rand.Next(-10, 11);
    int y = rand.Next(-10, 11);
    Console.WriteLine($"A({x}, {y})");
    CoordCheck(x, y);
}
void CoordCheck(int x, int y)
{
      if (x >0 && y>0)
    {
        Console.WriteLine("Точка находиться в 1ой четверти");
    }

    else if (x <0 && y>0)
    {
        Console.WriteLine("Точка находиться в 2ой четверти");
    }
    
     else if (x <0 && y<0)
    {
        Console.WriteLine("Точка находиться в 3ой четверти");
    }

     else if (x >0 && y<0)
    {
        Console.WriteLine("Точка находиться в 4ой четверти");
    }
    else 
    {
        Console.WriteLine("Точка лежит на одной из осей");
    }

}


Zadacha17();