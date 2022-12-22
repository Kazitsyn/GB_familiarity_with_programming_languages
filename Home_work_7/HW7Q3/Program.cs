/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

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
PrintMatrix(matrixRandom);
PrintTask52(GetAverageColumns(matrixRandom));
