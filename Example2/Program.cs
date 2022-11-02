// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел
Console.WriteLine("Введите три целых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if(num1>num2 && num1>num3)
{
    Console.WriteLine($"Число {num1} максимальное");
}
else if(num2>num1 && num2>num3)
{
    Console.WriteLine($"Число {num2} максимальное");
}
else
{
    Console.WriteLine($"Число {num3} максимальное");
}