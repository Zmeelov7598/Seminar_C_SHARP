//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("ВВедите число!");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int ost = 0;
while (i <= N)
{
    ost = i % 2;
    if (ost == 0)
    {
        Console.Write($"{i}, ");
        i++;
    }
    else
    {
        i++;
    }
}