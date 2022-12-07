# Знакомство с языком программирования С#
## Домашняя работа № 3 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_3)
***
### **Задача 19** *Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*


* 14212 -> нет

* 12821 -> да

* 23432 -> да

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_3/HW3Q1)
```c#
int GetIndex(int number, int index = 0)
{
    int count = Convert.ToString(number).Length;
    if (index < count)
    {
        int result = -1;
        int del = 1;
        int ost = 10;

            for (int i = 0; i <= index; i++)
            {
                result = (number % ost) / del;
                ost *= 10;
                del *= 10;
            }
            return result;
    }
    else return -1;
}

bool Palindrome(int number)
{
    if (GetIndex(number) == GetIndex(number, 4) && GetIndex(number, 1) == GetIndex(number, 3))
    {
        return true;
    }
    else return false;
}

void Print(int number, bool palindrome)
{
    if (palindrome == true)
    {
        Console.WriteLine($"{number} -> да");
    }
    else Console.WriteLine($"{number} -> нет");
}



Print(14212, Palindrome(14212));
Print(12821, Palindrome(12821));
Print(23432, Palindrome(23432));

int number = new Random().Next(10000, 99999);
Print(number, Palindrome(number));
```
Вывод консоли:
```c#
14212 -> нет
12821 -> да
23432 -> да
73453 -> нет
```
***
### **Задача 21** *Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*

* A (3,6,8); B (2,1,-7), -> 15.84

* A (7,-5, 0); B (1,-1,9) -> 11.53


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_3/HW3Q2)
```c#
double DistXY (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
    return result;
}

Console.Write($"A (3,6,8); B (2,1,-7), -> {DistXY(x1: 3, y1: 6, z1: 8, x2: 2, y2: 1, z2: -7)}\n");
Console.Write($"A (7,-5, 0); B (1,-1,9) -> {DistXY(x1: 7, y1: -5, z1: 0, x2: 1, y2: -1, z2: 9)}\n");
```
Вывод консоли:
```c#
A (3,6,8); B (2,1,-7), -> 15,84297951775486
A (7,-5, 0); B (1,-1,9) -> 11,532562594670797
```
***
### **Задача 23:** *Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*

* 3 -> 1, 8, 27

* 5 -> 1, 8, 27, 64, 125


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_3/HW3Q3)
```c#
void NumberCube(int N)
{
    Console.Write($"{N} -> ");
    for(int i = 1;i <= N; i++)
    {
        Console.Write($"{i * i * i}");
        if (i != N) Console.Write(", ");
        else Console.WriteLine();
    }
}

NumberCube(3);
NumberCube(5);

NumberCube(new Random().Next(1, 20));
```
Вывод консоли:
```c#
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
14 -> 1, 8, 27, 64, 125, 216, 343, 512, 729, 1000, 1331, 1728, 2197, 2744
```
***