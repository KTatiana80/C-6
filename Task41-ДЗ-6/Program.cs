// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
}

int[] CreateArrayBySize(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Вводите числа по одному");
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int GetCountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("Введите количество проверяемых чисел");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayBySize(m);
int countPositive = GetCountPositive(arr);
PrintArray(arr);
Console.Write(" -> " + countPositive);
