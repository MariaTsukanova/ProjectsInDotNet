// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

double min = double.MaxValue;
double max = double.MaxValue;
double[] array = GenArray(5, 10, 100);
Print1DArr(array);
MinMax(array);
PrintData("Разница между максимальным и минимальным элементом массива равна " + (max-min));


//Генерируем массив 
double[] GenArray(int len, double minValue, double maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1));
    }
    return arr;
}

// Печатаем одномерный массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

void MinMax(double[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        if(arr[i] > max) 
        {
            max = arr[i];
        }
        if(arr[i] < min) 
        {
            min = arr[i];
        }
    }
}


// Вывод результата
void PrintData(string res)
{
    Console.WriteLine(res);
}
