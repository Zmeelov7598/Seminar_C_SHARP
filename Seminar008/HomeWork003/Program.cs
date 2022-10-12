// Задайте две матрицы
// Напишите программу которая будет находить произведение двух матриц

int[,] GetDemension()
{
    Console.WriteLine("\nПеремнодение двух квадратных матриц");
    Console.WriteLine();
    Console.WriteLine("Введите количество строк и столбцов в массиве: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[m, m];
    return arr;
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

void MultiplicationArray(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(1); k++)
            {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
}

int[,] massiv1 = GetDemension();
int[,] massiv2 = new int[massiv1.GetLength(0), massiv1.GetLength(1)];
int[,] massiv3 = new int[massiv1.GetLength(0), massiv1.GetLength(1)];

FillArray(massiv1);
FillArray(massiv2);
PrintArray(massiv1);
PrintArray(massiv2);
MultiplicationArray(massiv1,massiv2,massiv3);
PrintArray(massiv3);
