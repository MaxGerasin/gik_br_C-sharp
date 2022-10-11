/* Напишите программу, которая будет преобразовывать десятичное число в двоичное */

void Zadacha2()
{
    int number = 43;
    string result = "";
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    Console.WriteLine(result);
}
Zadacha2();

/* int number = 43;
string result = ConvertToString(number, 2);
Console.WriteLine(result);
 */