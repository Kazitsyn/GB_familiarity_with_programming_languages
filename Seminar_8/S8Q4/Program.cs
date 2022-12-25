/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
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

int[,] MatrixMinus(int[,] matrix)
{
    int[,] minus = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0; i < minus.GetLength(0); i++)
    {
        for (int j = 0; j < minus.GetLength(1); j++)
        {
            minus[i,j] = matrix[i+1,j+1];
        }
    }
    return minus;
}



int rows = GetNumber("Введите количесво строк: ");
int columns = GetNumber("Введите количесво столбцов: ");
DateTime start = DateTime.Now;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);

PrintMatrix(MatrixMinus(matrix));


Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");

/*
Alina: int m = GetNumber("Введите количество строк:");
int n = GetNumber("Введите количество столбцов:");
int[,] matrix = new int[m, n];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);
PrintArray(DeleteRowColoumn(matrix));



int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

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
void FillArrayRandomNumbers(int[,] matrix)
{
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(1, 10);
}
}
}
Anna1606: ну вот две 1 в разных столбцах
Alina: void PrintArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("[ ");
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write(matrix[i, j] + " ");
}
Console.Write("]");
Console.WriteLine("");
}
}

int[,] DeleteRowColoumn(int[,] matrix)
{
int min = matrix[0, 0];
int x = 0;
int y = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i, j] < min)
{
min = matrix[i,j];
x = i;
y = j;
}
}
}
Alina: int[,] newArr = new int[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1];
int a = 0;
int b = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
if (i == x)
continue;
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j == y)
continue;
newArr[a, b] = matrix[i, j];
b++;
}
b = 0;
a++;
}
return newArr;
}
*/