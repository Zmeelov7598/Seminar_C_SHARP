// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трехзначное число: ");
int ThreeDigitNumber = int.Parse(Console.ReadLine() ?? "0");
int[] arrayTDN = new int[3];

for (int i = 2; i >= 0; i--)
{
    arrayTDN[i] = ThreeDigitNumber % 10;
    ThreeDigitNumber /= 10;
}

Console.WriteLine(arrayTDN[1]);
