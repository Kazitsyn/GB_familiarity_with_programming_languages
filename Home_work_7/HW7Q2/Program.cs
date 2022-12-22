/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/


int[,] matrix = new int[,]{ {1, 4, 7, 2},
                            {5, 9, 2, 3},
                            {8, 4, 2, 4}};



string GetElementMatrix(int[,] matrix, int i, int j)
{
    string result = String.Empty;
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) return Convert.ToString(matrix[i,j]);
    else return "такого числа в массиве нет";
    
}

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

int i = GetNumber("i = ");
int j = GetNumber("j = ");
string element = GetElementMatrix(matrix, i, j);
Console.WriteLine($"{i} {j} -> {element}");
