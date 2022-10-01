//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
int GetNumberA()
{
    Console.WriteLine("Введите число А!");
    return Convert.ToInt32(Console.ReadLine());
}
int GetNumberB()
{
    Console.WriteLine("Введите число В!");
    return Convert.ToInt32(Console.ReadLine());
}
int DegreeCalc(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int A = GetNumberA();
int B = GetNumberB();

Console.WriteLine("Число " + A + " в степени "  + B +  " равно " + DegreeCalc(A,B));
