// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число!");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"MIN={b}");
    Console.WriteLine($"MAX={a}");
}
else if (a < b)
{
    Console.WriteLine($"MIN={a}");
    Console.WriteLine($"MAX={b}");
}
else if (a == b)
{
    Console.WriteLine("Вы ввели два одинаковых числа! MIN=MAX");
}