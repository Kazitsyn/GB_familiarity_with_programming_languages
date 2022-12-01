/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int Max(int a, int b)
    {
    int max = a;
    if (a < b) max = b;
    return max;
    }

Console.WriteLine(Max(5, 7));
Console.WriteLine(Max(2, 10));
Console.WriteLine(Max(-9, -3));

// Console. WriteLine("Введите a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console. WriteLine("Введите b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Max(a, b));