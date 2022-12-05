//Считываем данные с консоли
string? numLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(numLine!=null)
{
    //Парсим введенное число
    int number = int.Parse(numLine);

    //Вводим счетчик цикла начиная с 2, т.к. нужны четные числа
    int index = 2;

    //Вводим пустую переменную, в которую будем записывать результат
    string result = string.Empty;

    //Вводим условие цикла
    while(index <= number - 2)
    { 
        //Записываем в результат все четные числа, последовательно увеличивая счетчик, до выполнения условия цикла
        result = result + index + " , ";
        index = index + 2;
    }

    //Добавляем к результату последнее число
    result = result + index;

    //Выводим результат
    Console.WriteLine(result);

}
