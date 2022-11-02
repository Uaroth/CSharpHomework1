// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите два целых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2} ");
}
else if(num1<num2)
{
    Console.WriteLine($"Число {num2} больше числа {num1} ");
}
else
{
    Console.WriteLine($"Числа равны");
}