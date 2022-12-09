# Знакомство с языком программирования С#
## Домашняя работа № 3 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_4)
***
### **Задача 25** *Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*


* 3, 5 -> 243 (3⁵)

* 2, 4 -> 16


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_4/HW4Q1)
```c#
int Pow(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}

void PrintPow(int A, int B)
{
    Console.WriteLine($"{A}, {B} -> {Pow(A, B)}");
}

PrintPow(3, 5);
PrintPow(2, 5);

PrintPow(new Random().Next(1, 10), new Random().Next(1, 10));
```
Вывод консоли:
```c#
3, 5 -> 243
2, 5 -> 32
3, 7 -> 2187
```
***
### **Задача 27** *Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*

* 452 -> 11

* 82 -> 10 
 
* 9012 -> 12


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_4/HW4Q2)
```c#
int SumIndex(int number)
{
    int count = Convert.ToString(number).Length;
    int result = 0;
    int del = 1;
    int ost = 10;

        for (int i = 0; i <= count; i++)
        {
            result += (number % ost) / del;
            ost *= 10;
            del *= 10;
             
        }
    return result;
}

void PrintSumIndex(int number)
{
    Console.WriteLine($"{number} -> {SumIndex(number)}");
}

PrintSumIndex(452);
PrintSumIndex(82);
PrintSumIndex(9012);

PrintSumIndex(new Random().Next(1, 999999999));
```
Вывод консоли:
```c#
452 -> 11
82 -> 10
9012 -> 12
941520409 -> 34
```
***
### **Задача 29:** *Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*

* 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

* 6, 1, 33 -> [6, 1, 33]


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_4/HW4Q3)
```c#
int[] GetRandomArr(int length = 8, int randomIn = 0, int randomout = 99)
{
    int [] Arr = new int [length];
    for (int i = 0; i < length; i++)
    {
        Arr[i] = new Random().Next(randomIn, randomout);
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
    Console.WriteLine();
}



PrintArr(new int []{1, 2, 5, 7, 19});
PrintArr(new int []{6, 1, 33});

PrintArr(GetRandomArr());
PrintArr(GetRandomArr(new Random().Next(1, 9), 0, 9999));
```
Вывод консоли:
```c#
[1, 2, 5, 7, 19]
[6, 1, 33]
[87, 54, 7, 25, 86, 36, 75, 81]
[8946, 2531, 4877, 3506, 8592, 1470, 402]
```
***