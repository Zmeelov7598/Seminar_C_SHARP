int GetDemension(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

void FillArray(int[,] arr,int n)
{
    int num = 1;
    for (int delta = 0; delta < n - 2; delta++)
    {
        for (int i = 0 + delta; i < n - delta; i++)
        {
            arr[0 + delta, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + delta; i < n - delta; i++)
        {
            arr[i, n - 1 - delta] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - delta; i >= 0 + delta; i--)
        {
            arr[n - 1 - delta, i] = num;
            num++;
        }
        num--;
        for (int i = n - 1 - delta; i >= 1 + delta; i--)
        {
            arr[i,0+delta]=num;
            num++;
        }
    }
}

int n = GetDemension("Введите количество строк/ стобцов в матрице");
int[,] massiv = new int[n, n];
PrintArray(massiv);
FillArray(massiv,n);
PrintArray(massiv);
