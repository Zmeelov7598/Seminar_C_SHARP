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
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
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
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = count;
                count += 1;
                if (count >= 100) break;
            }
            if (count >= 100) break;
        }
        if (count >= 100) break;
    }
    if (count >= 100) 
        {
            Console.WriteLine("Слишком БОЛЬШОЙ задан массив");
        }

}

int[,,] massiv = GetDemension();
FillArray(massiv);
PrintArray(massiv);
