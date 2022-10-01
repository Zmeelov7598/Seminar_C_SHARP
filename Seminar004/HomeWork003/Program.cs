// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
int GetNumber()
{
    Console.WriteLine("Введите чсило обозначающее длинну массива!");
    return Convert.ToInt32(Console.ReadLine());
}
void CreatArray(int a)
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++)
    {
        if (i == a-1)
        {
          array[i] = new Random().Next(0,21);
        Console.Write(array[i]); 
        Console.WriteLine();
        break;
        }

        array[i] = new Random().Next(0,21);
        Console.Write(array[i] + ",");
    }
}
CreatArray(GetNumber());