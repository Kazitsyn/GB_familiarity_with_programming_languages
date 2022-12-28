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
### Метод создания матрицы случайных чисел от 1 до 9
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
### **Задача 56** *Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*

* Например, задан массив:

* 1 4 7 2

* 5 9 2 3

* 8 4 2 4

* 5 2 6 7

* Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_8/HW8Q2)
```c#
// Метод решения задачи
string Task56(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    int sum = 0;
    int sumMin = 2147483647;
    int index = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i,j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            index = i+1;
        }
        sum = 0;

    }
    return $"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {index} строка";
}


int rows = GetNumber("Введите количесво строк: ");
int columns = GetNumber("Введите количесво столбцов: ");
DateTime start = DateTime.Now;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);
string text = Task56(matrix);
Console.WriteLine(text);

Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");
```
Вывод консоли:
```c#
Введите количесво строк: 5
Введите количесво столбцов: 4

3 8 8 9
8 2 5 6
9 7 3 2
2 3 1 9
5 8 1 9

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 4 строка
Время выполнения программы: 10,8531 милисекунд.
```
***
### **Задача 58:** *Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*

* Например, даны 2 матрицы:

* 2 4 | 3 4
* 3 2 | 3 3
* Результирующая матрица будет:
* 18 20
* 15 18


[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_8/HW8Q3)
```c#
// Метод решения задачи
int[,] Task58(int[,] matr1, int[,] matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(0)];
    int length = matr1.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            for (int k = 0; k < length; k++)
            {
                result[i,j] += matr1[i,k]*matr2[k,j];
            }
        }
    }
    return result;
}

int rows = GetNumber("Введите количесво строк: ");
int columns = GetNumber("Введите количесво столбцов: ");
DateTime start = DateTime.Now;
int[,] matrix = InitMatrix(rows,columns);
int[,] matrix2 = InitMatrix(rows,columns);

PrintMatrix(matrix);
PrintMatrix(matrix2);
int[,] matrix3 = Task58(matrix, matrix2);
int[,] mat1 = {{2, 4}, {3, 2}};
int[,] mat2 = {{3, 4}, {3, 3}};
int[,] mat3 = Task58(mat1, mat2);
PrintMatrix(matrix3);
PrintMatrix(mat3);
Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");
```
Вывод консоли:
```c#
Введите количесво строк: 3
Введите количесво столбцов: 3

3 8 9
6 5 9
4 7 8

7 7 6
7 3 8
8 3 9

149 72 163
149 84 157
141 73 152

18 20
15 18

Время выполнения программы: 15,5472 милисекунд.
```
***
### **Задача 60:** *Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*

* Массив размером 2 x 2 x 2

* 66(0,0,0) 25(0,1,0)
* 334(1,0,0) 41(1,1,0)
* Р27(0,0,1) 90(0,1,1)
* 26(1,0,1) 55(1,1,1)



[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_8/HW8Q4)
```c#
// Метод решения задачи
int[,,] Task60(int iL = 2, int jL = 2, int kL = 2)
{
    int[,,] result = new int[iL,jL,kL];
    int num = 10;
    for (int i = 0; i < iL; i++)
    {
        for (int j = 0; j < jL; j++)
        {
            for (int k = 0; k < kL; k++)
            {
                result[i,j,k] = num;
                num++;
            }
        }
    }
    return result;
}

void PrintTask60(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i,j,k]}({j},{k},{i}) ");
            }
        }
    }
    Console.WriteLine();
}
DateTime start = DateTime.Now;

PrintTask60(Task60());

Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");
```
Вывод консоли:
```c#
10(0,0,0) 11(0,1,0) 
12(1,0,0) 13(1,1,0)
14(0,0,1) 15(0,1,1)
16(1,0,1) 17(1,1,1)
Время выполнения программы: 11,5937 милисекунд.
```
***
### **Задача 61:** *Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника (задачка со звездочкой)*




[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_8/HW8Q5)
```c#
int Fact(int n)
{
    if (n == 0)
    {
        return 1;
    }
    return n*Fact(n-1);
}

void Pasc(int n)
{
    Console.WriteLine();
    for (int i = 0; i < n; i++)
        {
            for (int c = 0; c <= (n - i); c++) 
            {
                Console.Write(" "); 
            }
            for (int c = 0; c <= i; c++)
            {
                Console.Write(" "); 
                Console.Write(Fact(i) / (Fact(c) * Fact(i - c))); 
            }
            Console.WriteLine(); 
        }
    Console.WriteLine();    
}

DateTime start = DateTime.Now;

Pasc(GetNumber("Введите N строк треугольника Паскаля: "));

Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");
```
Вывод консоли:
```c#
Введите N строк треугольника Паскаля: 5

       1
      1 1
     1 2 1
    1 3 3 1
   1 4 6 4 1

Время выполнения программы: 715,7204 милисекунд.
```
***
### **Задача 62:** *Напишите программу, которая заполнит спирально массив 4 на 4.*

* Например, на выходе получается вот такой массив:

* 01 02 03 04
* 12 13 14 05
* 11 16 15 06
* 10 09 08 07



[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_work_8/HW8Q6)
```c#
int[,] Spiral(int num)
{
    int[] jndex = {0,1,2,3,3,3,3,2,1,0,0,0,1,2,2,1};
    int[] index = {0,0,0,0,1,2,3,3,3,3,2,1,1,1,2,2};
    int[,] arr = new int [4,4];
    for (int i = 0; i < index.Length; i++)
        arr[index[i],jndex[i]] = num++;
    
    return arr;
}

int num = GetNumber("Введите начальное число заполнения: ");
DateTime start = DateTime.Now;
PrintMatrix(Spiral(num));
Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");
```
Вывод консоли:
```c#
Введите начальное число заполнения: 10

10 11 12 13 
21 22 23 14
20 25 24 15
19 18 17 16

Время выполнения программы: 8,7159 милисекунд.
```
***