//Считываем данные с консоли
string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(num1Line!=null&&num2Line!=null)
{
    //Парсим введенное число
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    //Сравниваем числа и выводим результат в случае, когда первое число больше второго
    if(num1 > num2)
    {
        Console.WriteLine(num1 + " больше " + num2);
    }
    //Выводим результат в случае, когда второе число больше первого
    else
    {
        Console.WriteLine(num2 + " больше " + num1);
    }
}

