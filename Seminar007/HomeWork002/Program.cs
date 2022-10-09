// Напишите программу которая на вход принемает позицию элемента в двухмерном массиве.
//  и возращает значение этого элемента. или пишет его нет.

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
void FindPosition(int[,] arr)
{
    Console.WriteLine("Введите номер позиции строки элемента: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер позиции столбца элемента: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if ((m < arr.GetLength(0) && m >= 0) || (n < arr.GetLength(1) && m >= 0))
    {
        Console.WriteLine($"Элемент в строке {m} столбце {n} равен : {arr[m,n]}");
    }
    else Console.WriteLine("Такой позиции нет в массиве!");

}

int[,] massiv = DemensionArray();
PrintArray(massiv);
FillArray(massiv);
Console.WriteLine();
PrintArray(massiv);
Console.WriteLine();
FindPosition(massiv);
// позицию Элемента считал от 0.
// при необходимости возможно переделать