/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

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
}

PrintTask60(Task60());