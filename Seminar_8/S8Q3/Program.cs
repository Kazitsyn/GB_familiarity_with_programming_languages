/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/

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


void CalculateNumbers (int[,] matrix)
{
int m = matrix.GetLength(0);
int n = matrix.GetLength(1);
int numberOfElements = m * n;
int number = 0;
int count = 0;
int total = 0;

while (total != numberOfElements)
{
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
{
if(matrix[i, j] == number)
{
count++;
}
}
}
if(count > 0)
    System.Console.WriteLine($"Число {number} встречается {count} раз;");
total+= count;
count = 0;
number++;
}
}

int rows = GetNumber("Введите количесво строк: ");
int columns = GetNumber("Введите количесво столбцов: ");
DateTime start = DateTime.Now;
int[,] matrix = InitMatrix(rows,columns);
PrintMatrix(matrix);

CalculateNumbers(matrix);


Console.WriteLine($"Время выполнения программы: {(DateTime.Now-start).TotalMilliseconds} милисекунд.");