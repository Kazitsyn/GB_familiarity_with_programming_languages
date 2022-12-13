# Знакомство с языком программирования С#
## Домашняя работа № 5 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_5)
***
### **Задача 34** *Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.*


* [345, 897, 568, 234] -> 2



[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_5/HW5Q1)
```c#
int[] GetRandomArr(int length = 8, int randomIn = 100, int randomout = 1000)
{
    int [] Arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        Arr[i] = rnd.Next(randomIn, randomout);
    }
    return Arr;
}

void PrintArr(int [] Arr)
{
    Console.Write("[");
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i]);
        if (i < Arr.Length -1) Console.Write(", ");
    }
    Console.Write("] ");
}

int EvenArr(int[] arr)
{
    int result = 0;
    foreach (int k in arr) 
    {
        if (k % 2 == 0) result++;
    }
    return result;
}

int[] test = new int[] {345, 897, 568, 234};
PrintArr(test);
Console.Write($" -> {EvenArr(test)}");

Console.WriteLine();

int[] arr = GetRandomArr();
PrintArr(arr);
Console.Write($" -> {EvenArr(arr)}");
```
Вывод консоли:
```c#
[345, 897, 568, 234]  -> 2
[196, 240, 934, 657, 758, 787, 118, 798]  -> 6
```
***
### **Задача 36** *Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*

* [3, 7, 23, 12] -> 19

* [-4, -6, 89, 6] -> 0
 

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_5/HW5Q2)
```c#
int[] GetRandomArr(int length = 8, int randomIn = -100, int randomout = 100)
{
    int [] Arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        Arr[i] = rnd.Next(randomIn, randomout);
    }
    return Arr;
}

void PrintArr(int [] Arr)
{
    Console.Write("[");
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i]);
        if (i < Arr.Length -1) Console.Write(", ");
    }
    Console.Write("] ");
}

int OddArr(int[] arr)
{
    int result = 0;
    for (int k = 1; k < arr.Length; k += 2)
    {
        result += arr[k];
    }
    return result;
}

int[] test = new int[] {3, 7, 23, 12};
PrintArr(test);
Console.Write($" -> {OddArr(test)}");

Console.WriteLine();

int[] test2 = new int[] {-4, -6, 89, 6};
PrintArr(test2);
Console.Write($" -> {OddArr(test2)}");

Console.WriteLine();

int[] arr = GetRandomArr();
PrintArr(arr);
Console.Write($" -> {OddArr(arr)}");
```
Вывод консоли:
```c#
[3, 7, 23, 12]  -> 19
[-4, -6, 89, 6]  -> 0
[25, 87, 88, -71, 86, -28, 4, -35]  -> -47
```
***
### **Задача 38:** *Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*

* [3 7 22 2 78] -> 76


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_5/HW5Q3)
```c#
// Получить рандомный массив вещественных чисел по умолчанию (длина 6, рандом от 0 до 100)
double [] GetRandomArr(int length = 6,  int maxR = 100)
{
    double [] Arr = new double [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        Arr[i] = rnd.NextDouble() * maxR;
    }
    return Arr;
}

// Вывести массив в квадратных скобках вещественных чисел (2 знака после запятой)
void PrintArr(double [] Arr)
{
    Console.Write("[");
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write("{0:F2}", Arr[i]);
        if (i < Arr.Length -1) Console.Write(" ");
    }
    Console.Write("] ");
}

//Получить мин и макс массива вещественных чисел
 (double, double) GetMinMaxArr(double[] arr)
{
    double min = arr[0];
    double max = 0;
    foreach (double k in arr)
    {
        if (k < min) min = k;
        if (k > max) max = k;
    }
    return  (min, max);
}

double[] test = new double[] {3, 7, 22, 2, 78};
(double min , double max) = GetMinMaxArr(test);
Console.Write($"[3, 7, 22, 2, 78] -> ");
Console.WriteLine(max - min);

double[] arr = GetRandomArr();
PrintArr(arr);
(double minArr, double maxArr) = GetMinMaxArr(arr);
Console.WriteLine(" -> {0:F2}", (maxArr - minArr));
```
Вывод консоли:
```c#
[3, 7, 22, 2, 78] -> 76
[17,31 61,07 61,75 75,50 41,44 3,19]  -> 72,30
```
***