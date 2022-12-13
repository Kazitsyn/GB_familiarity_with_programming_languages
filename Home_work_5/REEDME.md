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

int[] arr = GetRandomArr();
PrintArr(arr);
Console.Write($" -> {EvenArr(arr)}");
```
Вывод консоли:
```c#
[325, 550, 983, 282, 711, 299, 950, 500]  -> 4
```
***
### **Задача 36** *Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*

* [3, 7, 23, 12] -> 19

* [-4, -6, 89, 6] -> 0
 

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_5/HW5Q2)
```c#

```
Вывод консоли:
```c#

```
***
### **Задача 38:** *Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*

* [3 7 22 2 78] -> 76


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_5/HW5Q3)
```c#

```
Вывод консоли:
```c#

```
***