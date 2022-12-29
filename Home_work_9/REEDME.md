# Знакомство с языком программирования С#
## Домашняя работа № 9 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_9)
***
### Метод ввода чисел пользователем
```c#
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write (message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
```

***
### **Задача 64** *Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*


* N = 5 -> "5, 4, 3, 2, 1"

* N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_9/HW9Q1)
```c#
string Task64(int n)
{
    if(n == 1) return "1";
    return $"{n} {Task64(n-1)}";
}

Console.WriteLine(Task64(GetNumber("Введите чило для задачи 64: ")));
Console.WriteLine(Task64(5));
Console.WriteLine(Task64(8));
```
Вывод консоли:
```c#
Введите чило для задачи 64: 13
13 12 11 10 9 8 7 6 5 4 3 2 1
5 4 3 2 1
8 7 6 5 4 3 2 1
```
***
### **Задача 66** *Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*

* Например, задан массив:

* M = 1; N = 15 -> 120

* M = 4; N = 8. -> 30
 

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_9/HW9Q2)
```c#
int Task66(int M, int N)
{
    if(M == N) return M;
    return (N+Task66(M, N-1));
}

Console.WriteLine(Task66(GetNumber("M = "),GetNumber("N = ")));
Console.WriteLine(Task66(1,15));
Console.WriteLine(Task66(4,8));
```
Вывод консоли:
```c#
M = 2
N = 13
90
120
30
```
***
### **Задача 68:** *Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*

* m = 2, n = 3 -> A(m,n) = 9

* m = 3, n = 2 -> A(m,n) = 29


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_9/HW9Q3)
```c#
int Task68(int m, int n)
{
    if(m == 0) return n+1;
    else if(n == 0) return Task68(m-1, 1);
    else return Task68(m-1,Task68(m, n-1));
}

Console.WriteLine(Task68(2,3));
Console.WriteLine(Task68(3,2));
```
Вывод консоли:
```c#
9
29
```
***