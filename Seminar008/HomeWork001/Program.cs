// Задайте двухмерный массив.
// Напишите программу которая упорядочит по убыванию элементы
// каждой строки двухмерного массива.

int[,] GetDemension()
{
    Console.WriteLine("Введите количество строк в массиве: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[m, n];
    return arr;
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
    Console.WriteLine();
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void ArrangeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = 0;
                    temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

int[,] massiv = GetDemension();
FillArray(massiv);
PrintArray(massiv);
ArrangeArray(massiv);
PrintArray(massiv);
