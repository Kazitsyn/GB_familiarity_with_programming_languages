# Знакомство с языком программирования С#
## Домашняя работа № 7 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_7)
***
### Методы применяемые в решениях задач

Метод ввода чисел.
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
### **Задача 47** *Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*


* m = 3, n = 4.

* 0,5 7 -2 -0,2

* 1 -3,3 8 -9,9

* 8 7,8 -7,1 9



[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_7/HW7Q1)
```c#
double[ , ] GetRandomArray(int line, int column)
{
    double[ , ] array = new double[line, column];
    Random rnd = new Random();
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = rnd.NextDouble() * 10;
        }
    }
    return array;
}

void PrintArray(double[ , ] array)
{
    Console.WriteLine($"m = {array.GetLength(0)}, n = {array.GetLength(1)}.");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:F1}", array[i, j]);
            Console.Write(" ");
        }
            
        Console.WriteLine();
    }
    
}

double[ , ] array = GetRandomArray(3,4);
PrintArray(array);
```
Вывод консоли:
```c#
m = 3, n = 4.
8,4 10,0 4,6 8,8
7,1 1,9 8,1 3,8
4,3 3,5 9,2 3,5
```
***
### **Задача 50** *Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.*

* Например, задан массив:

* [1 4 7 2

* 5 9 2 3

* 8 4 2 4

* 17 -> такого числа в массиве нет
 

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_7/HW7Q2)
```c#
int[,] matrix = new int[,]{ {1, 4, 7, 2},
                            {5, 9, 2, 3},
                            {8, 4, 2, 4}};



string GetElementMatrix(int[,] matrix, int i, int j)
{
    string result = String.Empty;
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) return Convert.ToString(matrix[i,j]);
    else return "такого числа в массиве нет";
    
}

int i = GetNumber("i = ");
int j = GetNumber("j = ");
string element = GetElementMatrix(matrix, i, j);
Console.WriteLine($"{i} {j} -> {element}");
```
Вывод консоли:
```c#
i = 0
j = 1
0 1 -> 4
```
***
### **Задача 52:** *Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*

* Например, задан массив:

* 1 4 7 2
* 5 9 2 3
* 8 4 2 4
* Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_7/HW7Q3)
```c#
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    } 
    return matrix;
}

double[] GetAverageColumns(int[,] matrix)
{
    int rows = matrix.GetLength(1);
    int columns = matrix.GetLength(0);
    double[] average = new double[rows];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            average[j] += matrix[i,j];
        }
    }
    for (int i = 0; i < rows; i++) 
    {
        average[i] /= columns; 
    }
    return average;
} 

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

void PrintTask52(double [] arr)
{
        Console.Write($"Среднее арифметическое каждого столбца: ");
        foreach (double k in arr) 
        {
            Console.Write("{0:F2}", k);
            Console.Write("; ");
        } 
        Console.WriteLine();
}

int[,] matrix = new int[,]{ {1, 4, 7, 2},
                            {5, 9, 2, 3},
                            {8, 4, 2, 4}};

PrintMatrix(matrix);
PrintTask52(GetAverageColumns(matrix));

int[,] matrixRandom = InitMatrix(GetNumber("Введите количество строк: "), GetNumber("Введите количество столбцов: "));

Console.WriteLine();

PrintMatrix(matrixRandom);
PrintTask52(GetAverageColumns(matrixRandom));
```
Вывод консоли:
```c#

1 4 7 2 
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,67; 5,67; 3,67; 3,00;

Введите количество строк: 5
Введите количество столбцов: 5

4 9 1 6 7
2 9 6 4 2
2 9 4 4 1
8 2 6 2 5
8 6 2 4 5

Среднее арифметическое каждого столбца: 4,80; 7,00; 3,80; 4,00; 4,00;
```
***