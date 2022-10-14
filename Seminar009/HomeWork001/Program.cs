// Задайте значение N.Напишите программу, к
// которая выведет все натуральные числа в промежутке от N до 1.
// выполнить с помощью рекрсии

void Sequence(double number)
{
    if (number > 1)
    {
        Console.Write($"{number},");
        Sequence(number - 1);
    }
    else
    {
        Console.Write(number);
        Console.WriteLine();
    }
        
}

double GetNumber()
{
    Console.WriteLine("Введите число N");
    return Convert.ToDouble(Console.ReadLine());
}

Sequence(Math.Truncate(GetNumber()));