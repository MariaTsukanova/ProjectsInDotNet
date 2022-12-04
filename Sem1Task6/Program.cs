//Считываем данные с консоли
string? num1Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(num1Line!=null)
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);

    //Вводим переменную остатка от деления на 2
    int  remainderOfDiv = num1 % 2;

    //Вводим условие остатка от деления на два равного нулю и вывод
    if(remainderOfDiv == 0)
    {
        Console.WriteLine("четное");
    }
    //Вывод если остаток от деления на два не равен нулю
    else
    {
        Console.WriteLine("нечетное");
    }
}


