// Метод заполнения массива и печати его на экран

void FillArray(int[] collection)                             // Аргумент колекшен
{
int length = collection.Length;                              // Длинна массива
int index = 0;
while(index < length)
{
    collection[index] = new Random().Next(1, 10); //Обратиться к аргументу collec. на позицию index Положить новое целое случайное число в диопазоне от 1 до 10
    index ++;
}
}


void PrintArray(int[] col)                                 // void - метод, который не возвращает
{
    int count = col.Length;                                // Количество элементов
    int position = 0;                                      // указываем позицию
    while (position < count)
    {
        Console.WriteLine(col[position]);                  // показываем значение текущего элемента т.е. col[position]
        position++;
    }
}

                                                           // Нахождение позиции нужного элемента в массива
int IndexOf(int[] collection, int find)    // Называем метод и берем в качестве аргумента будет приходить массив collection и какой-то элемент find   
{
    int count = collection.Length;         // Определяем количество элементов count
    int  index = 0;                        // Индексы, чтобы щелкать массивы
    int position = -1;                      // Для сохранение позиции  -1 возвращение, если нету не одного элемента

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;             // Кладем значение index в position(Сохраняем значения индекса в position)
            break;                        // Чтобы убрать последнее вхождение и было ПЕРВОЕ
        }
        index++;
    }
    return position;
}   

int[] array = new int[10];                                  // Определили массив из  10 элементов

FillArray(array);                                   // в качестве аргумента передаем название нашего массива, метод FillArray заполнил нам его
PrintArray(array);                                 // распечатывает наш массив
Console.WriteLine();                              // Выводим пустую строчку Добавляем, чтобы быть уверенным, что не является выводом части массива

int pos = IndexOf(array, 4);                      // Определяем переменнюу pos и в нее положим результат работы метода IndexOf
                                                  //и в качестве аргумента будет наш массив array и будем искать 4
Console.WriteLine(pos);