// Сформируйте трехмерный массив из неповторяющихся двухзначных чисел. 
// Напишите программу которая построчно выводит массив.Добавляя индексы каждого элемента

int[,,] GetDemension()
{
    Console.WriteLine("Введите количество строк в массиве: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите глубину массива: ");
    int l = Convert.ToInt32(Console.ReadLine());
    int[,,] arr = new int[m, n, l];
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

void FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(1, 10);
            }
        }
    }
}

void CheckDoubleArray(int[,,] arr)
{
    int count = 0;
    int temp = arr[count,count,count];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == temp)
                {
                    arr[i, j, k] = new Random().Next(1, 10);
                    count = 0;
                    i=0;
                    j=0;
                    k=0;
                }
            }
        }
    }
    count+=1;
}

int[,,] massiv = GetDemension();
FillArray(massiv);
PrintArray(massiv);
CheckDoubleArray(massiv);
PrintArray(massiv);