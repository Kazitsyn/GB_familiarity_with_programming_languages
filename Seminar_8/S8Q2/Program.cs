/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя
*/
// Метод ввода пользовыателем числа
int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не чило");
        }
    }
    return result;
}

// Метод создания матрици случайных чисел от 1 до 9
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

// Метод вывода матрицы
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

// Метод решения задачи
int[,] Task55(int[,] matrix)
{
int m = matrix.GetLength(0);
int n = matrix.GetLength(1);
int[,] result = new int[n, m];
for (int i = 0; i < n; i++)
{
for (int j = 0; j < m; j++)
{
result[i, j] = matrix[j, i];
}
}
return result;
}



int rows = GetNumber("Введите количесво строк: ");
int columns = GetNumber("Введите количесво столбцов: ");
DateTime start = DateTime.Now;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);


PrintMatrix(Task55(matrix));

Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");