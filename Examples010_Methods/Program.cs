// 1 вид методов, Ничего не принимают и ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();


// 2 вид методов, Ничего не возвращают, но  принимают аргументы

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);


// 3 вид методов, что-то возвращают, но ничего не принимают. Если он возвращает, обезательно  указываем тип данных,
// которые мы ожидаем

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);


// 4 виде методов, что-то принимают и что-то возвращают

string Method4(int count, string text)
{
    int i = 0;        // цикл
    string result = String.Empty;    // переменная куда кладем результат
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");
Console.WriteLine(res);

