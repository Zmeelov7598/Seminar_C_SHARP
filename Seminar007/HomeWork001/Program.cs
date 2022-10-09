// Задайте двухмерный массив размером mxn
// Заполненный случайными вещественными числами

double[,] DemensionArray()
{
    Console.WriteLine("Введите количество строк массива :");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива : ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
}

double[,] massiv = DemensionArray();
Console.WriteLine();
PrintArray(massiv);
FillArray(massiv);
Console.WriteLine();
PrintArray(massiv);