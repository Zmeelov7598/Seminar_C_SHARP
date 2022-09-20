// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
void FindSecondDigit(int number)
{
    int[] arrayTDN = new int[3];
    for (int i = 2; i >= 0; i--)
    {
        arrayTDN[i] = number % 10;
        number /= 10;
    }
    Console.WriteLine("Второе число: " + arrayTDN[1]);
}

Console.Write("Введите трехзначное число: ");
FindSecondDigit(int.Parse(Console.ReadLine() ?? "0"));