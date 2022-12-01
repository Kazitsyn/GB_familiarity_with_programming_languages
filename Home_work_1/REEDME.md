# Знакомство с языком программирования С#
## Домашняя работа № 1 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_1)
***
### Задача 2: *Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*

* a = 5; b = 7 -> max = 7

* a = 2 b = 10 -> max = 10

* a = -9 b = -3 -> max = -3

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_1/HWQ1)
```c#
int Max(int a, int b)
    {
    int max = a;
    if (a < b) max = b;
    return max;
    }

Console.WriteLine(Max(5, 7));
Console.WriteLine(Max(2, 10));
Console.WriteLine(Max(-9, -3));
```
При вводе корректных данных по условии задачи:
```c#

Console. WriteLine("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Max(a, b));
```
***
### Задача 4: *Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.*

* 2, 3, 7 -> 7

* 44 5 78 -> 78

* 22 3 9 -> 22

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_1/HWQ2)
```c#
int Max(int arg1, int arg2, int arg3)
    {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
    }

Console.WriteLine(Max(2, 3, 7));
Console.WriteLine(Max(44, 5, 78));
Console.WriteLine(Max(22, 3, 9));
```
При вводе корректных данных по условии задачи:

```c#
Console. WriteLine("Введите первое чило: ");
int number0 = Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите второе чило: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console. WriteLine("Введите третье чило: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное введеное чило = " + Max(number0, number1, number2));
```
***
### Задача 6: *Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).*

* 4 -> да

* -3 -> нет

* 7 -> нет

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_1/HWQ3)
```c#
string Even(int number)
    {
    if (number % 2 == 0) return "да";  
    return "нет";
    }

Console.WriteLine(Even(4));
Console.WriteLine(Even(-3));
Console.WriteLine(Even(7));
```
При вводе корректных данных по условии задачи:
```c#
Console. WriteLine("Введите чило: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Even(number));
```
***
### Задача 8: *Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.*

5 -> 2, 4

8 -> 2, 4, 6, 8

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_1/HWQ4)
```c#
void EvenSequence(int N)
    {
    if (N >= 1)
        {
        for(int i = 1; N >= i; i++)
            {
            if (i % 2 == 0)
                {
                Console.Write(i);
                if(i > 1 && i < N-1) Console.Write(", ");
                } 
            }
        }
    Console.WriteLine();
    }

EvenSequence(5);
EvenSequence(8);
```
При вводе корректных данных по условии задачи:
```c#
Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
EvenSequence(N);
```
***