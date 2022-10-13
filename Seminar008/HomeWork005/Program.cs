// Напишите программу которая заполнить спирально массив 4*4

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
    int count = 1;
    if (count <= 4)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arr[0, i] = count;
            count += 1;
        }
    }
    if (count > 4 && count <= 7)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            arr[j, 3] = count;
            count += 1;
        }
    }
    if (count > 7 && count <= 10)
    {
        for (int k = 2; k != 0; k--)
        {
            arr[3, k] = count;
            count += 1;
        }
    }
    if (count > 9 && count <= 12)
    {
        for (int l = 3; l != 0; l--)
        {
            arr[l, 0] = count;
            count += 1;
        }
    }
    if (count > 12 && count <= 14)
    {
        for (int m = 1; m < arr.GetLength(1) - 1; m++)
        {
            arr[1, m] = count;
            count += 1;
        }
    }
    if (count==15)
    {
        arr[2,2]=count;
        count+=1;
    }
    if (count==16)
    {
        arr[2,1]=count;
        count+=1;
    }
}

int[,] massiv = new int[4, 4];
FillArray(massiv);
PrintArray(massiv);