// Задайте двухмерный массивв из целых чисел
// Найдите среднеарефметическое в каждом столбце

int[,] DemensionArray()
{
    Console.WriteLine("Введите количество строк в массиве : ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве : ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    return array;
}
void PrintArray(int[,] arr)
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
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void ArithmeticMean(int[,] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
            if (j == (arr.GetLength(0) - 1))
            {
                Console.WriteLine($"Среднее арефметическое стобца {i} равно {Math.Round(sum / (j + 1), 1)}");
                sum = 0;
            }
        }
    }
}

int[,] massiv = DemensionArray();
PrintArray(massiv);
FillArray(massiv);
Console.WriteLine();
PrintArray(massiv);
Console.WriteLine();
ArithmeticMean(massiv);