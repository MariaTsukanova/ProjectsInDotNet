int number = int.Parse(Console.ReadLine() ?? "0");

int result1 = number % 7;
int result2 = number % 23;

if ((result1 == 0) && (result2 == 0))
{
    Console.WriteLine("число кратно одновременно 7 и 23");
}
else
{
    Console.WriteLine("число не кратно одновременно 7 и 23");
}