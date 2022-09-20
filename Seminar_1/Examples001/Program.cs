// Написать программу, которая на вход принимает число и выдает его квадрат 
// т.е. (Число умноженное на само себя)

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());   // Convert.ToInt32 - конвентирует строку в число
int b;
b = a * a;
Console.WriteLine($"{a} * {a} = {b}");        // Инторполяция - Более красивое и понятное 
// Console.WriteLine("Результат: " + b); - классическое



// Ветвление
//
// int rain = 0 
// if (rain == 1)
// {
//   Console.WriteLine("Возьми зонт");   
// }
// else 
// {
//   Console.WriteLine("Мжешь идти в сандалях";
// }