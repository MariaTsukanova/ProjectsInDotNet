System.Random numberSintezator = new System.Random();

int num = numberSintezator.Next(100, 1000);

Console.WriteLine(num);

//int firstNumber = num/100;
//int thirdNumber = num%10;

//int result = firstNumber*10 + thirdNumber;

//int result = (num/100)*10 + num%10;

Console.WriteLine((num/100)*10 + num%10);

