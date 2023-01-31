﻿// Задача 42: 
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int BinarNumber(int num)
{
    int res = 0;
    int count = 1;
    while (num > 0)
    {
        res += num % 2 * count;
        num /= 2;
        count *= 10;
    }
    return res;
}

int result = BinarNumber(number);
Console.WriteLine(result);


// решение 2

string DecToBin(int num)
{
string result = string.Empty;
while (num > 0)
{
result = num % 2 + result;
num = num /2;
}

return result;
}


Console.Write("Введите десятичное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number1);

Console.Write(number1);
Console.Write(" -> ");
Console.Write(decToBin);