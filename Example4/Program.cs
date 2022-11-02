// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число N");
int numN = Convert.ToInt32(Console.ReadLine());
int num1 = 2;
while(num1<numN)
{
    Console.WriteLine(num1);
    num1 = num1 + 2;
}
Console.WriteLine("Чётных чисел от 1 до N не осталось");
