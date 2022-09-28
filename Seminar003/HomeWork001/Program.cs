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

int GetNUmber()
{
    int number = 0;
    while (number < 9999 || number > 99999)
    {
        Console.WriteLine("Введите пятизначное число: ");
        number = int.Parse(Console.ReadLine() ?? "0");
    }
    return number;
}

int number = GetNUmber();
int revers = Palindrom(number);
CheckPalindrom(number, revers);