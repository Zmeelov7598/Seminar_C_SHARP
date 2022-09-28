//Напишите программу которая на вход принимает число N и Выдает таблицу кубов чисел от 1 до N
int Number()
{
    Console.WriteLine("Введите число!");
    return int.Parse(Console.ReadLine() ?? "0");
}
void CubeSearch(int i)
{
    for (int count = 1; count <= i; count++)
    {
        Console.Write(Math.Pow(count,3) + " ");
    }
    Console.WriteLine();
}

CubeSearch(Number());