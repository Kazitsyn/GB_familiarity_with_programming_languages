# Знакомство с языком программирования С#
## Домашняя работа № 8 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_8)
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
### Метод создания матрици случайных чисел от 1 до 9
```c#
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns;j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
```
### Метод вывода матрицы
```c#
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1);j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
```

***
### **Задача 54** *Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*


* Например, задан массив:

* 1 4 7 2

* 5 9 2 3

* 8 4 2 4

* В итоге получается вот такой массив:

* 7 4 2 1

* 9 5 3 2

* 8 4 4 2



[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_8/HW8Q1)
```c#
// Метод решения задачи
void Task54(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    int[] rArr = new int[columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            rArr[j] = matrix[i,j];
        }
        Array.Sort(rArr);
        Array.Reverse(rArr);
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rArr[j];
        }
    }
    
}


int rows = GetNumber("Введите количесво строк: ");
int columns = GetNumber("Введите количесво столбцов: ");
DateTime start = DateTime.Now;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);
Task54(matrix);
PrintMatrix(matrix);

Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");
```
Вывод консоли:
```c#
Введите количесво строк: 5
Введите количесво столбцов: 5

1 4 7 3 6
7 8 4 7 4
6 9 5 6 7
5 8 9 7 8
8 2 4 9 6


7 6 4 3 1
8 7 7 4 4
9 7 6 6 5
9 8 8 7 5
9 8 6 4 2

Время выполнения программы: 18,4368 милисекунд.
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