// Пользователь вводит с клавиатуры М чисел. 
// Посчитать сколько чисел больше 0  ввел пользователь.
// 0,7,8,-2,-2 ----2

// ВАРИАНТ №1

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");


// ВАРИАНТ №2

int[] Inter()
{
    Console.WriteLine("Введите число обознаающее количество чисел");
    int Len = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[Len];
    for (int i = 0; i < massiv.Length; i++)
    {
        int temp = 0;
        Console.WriteLine($"Введите {i + 1} число :");
        temp = Convert.ToInt32(Console.ReadLine());
        massiv[i] = temp;
    }
    return massiv;
}

void PrintMassiv(int[] arr)
{
    Console.WriteLine("Вы ввели числа");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void Positiv(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных чисел рвно: {count}");
}
int[] Numbers = Inter();
PrintMassiv(Numbers);
Positiv(Numbers);