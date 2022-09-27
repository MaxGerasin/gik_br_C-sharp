/* Напишите программу, которая выводит случайное 3х значное число и 
   удаляет 2 цыфру этого числа */

Random random = new Random();
int number = random.Next(100, 1000);
Console.WriteLine(number);
int tr = number / 100;
int ones = number % 10;
Console.Write(tr);
Console.Write(ones);