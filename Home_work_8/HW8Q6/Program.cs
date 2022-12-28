/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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