/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

// Метод замены строк по условию задачи
void Task53(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] tempRows = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        tempRows[i] = matrix[0,i];
        matrix[0,i] = matrix[columns-1, i];
    }
    for (int i = 0; i < rows; i++)
    {
        matrix[columns-1, i] = tempRows[i];
    }
}


int rows = GetNumber("Введите количесво строк: ");
int columns = GetNumber("Введите количесво столбцов: ");
DateTime start = DateTime.Now;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);
Task53(matrix);
PrintMatrix(matrix);

Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");

/*
Решение у доски

void PrintArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
Console.WriteLine();
}
}

int[,] arr =
{
{ 1, 4, 7, 2 },
{ 5, 9, 2, 3 },
{ 8, 4, 2, 4 },
{ 5, 2, 6, 7 }
};

int[] line0 = new int[arr.GetLength(1)];
int[] line1 = new int[arr.GetLength(1)];

for (int i = 0; i < line0.Length; i++)
line0[i] = arr[0, i];

for (int i = 0; i < line0.Length; i++)
line1[i] = arr[arr.GetLength(0)-1, i];

PrintArray(arr);

for (int i = 0; i < line0.Length; i++)
arr[0, i] = line1[i];
for (int i = 0; i < line0.Length; i++)
arr[arr.GetLength(0) - 1, i] = line0[i];

Console.WriteLine();
Console.WriteLine();
PrintArray(arr);
*/