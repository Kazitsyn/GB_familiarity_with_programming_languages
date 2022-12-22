/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

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