//Вводим число и сразу парсим его
int number = int.Parse(Console.ReadLine() ?? "0");

//Ставим условие для проверки трехзначное число или нет
if (number < 1000 && number > 99)
{
    //Если условие выполняется, то делим число на 10 чтобы уменьшить его до двухзначного и уже от этого двухзначного берем остаток от деления на 10
    int result = (number/10)%10;
    //Выводим результат
    Console.WriteLine(result);
}
//Если условие не выполняется, то выводим следующую фразу:
else Console.WriteLine("вы ввели не трехзначное число");

