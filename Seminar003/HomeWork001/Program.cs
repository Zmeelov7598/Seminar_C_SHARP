int Palindrom(int number)
{
    int n = number;
    int rev = 0;
    while (rev <= 9999)
    {
        int ost = n % 10;
        rev = rev * 10 + ost;
        n = n / 10;
    }
    return (rev);
}

void CheckPalindrom(int i, int j)
{
    if (i == j)
    {
        Console.WriteLine("Да это число палиндром!");
    }
    else 
    {
        Console.WriteLine("НЕТ это число не палиндром!");
    }
}

Console.Write("Введите пятизначное число : ");
int number = int.Parse(Console.ReadLine() ?? "0");
int revers = Palindrom(number);
CheckPalindrom(number, revers);