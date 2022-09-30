DateTime lastTime = DateTime.Now;     // Счетчик  времени. DateTime.Now - измеряет текущее время

int number = 123;

for(int i = 0; i < 100000000; i++ )   // Задаем цыкл
{
    var n = number/10%10;
}
Console.WriteLine(DateTime.Now - lastTime);