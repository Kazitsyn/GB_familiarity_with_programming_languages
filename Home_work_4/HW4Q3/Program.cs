/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] GetRandomArr(int length = 8, int randomIn = 0, int randomout = 99)
{
    int [] Arr = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        Arr[i] = rnd.Next(randomIn, randomout);
    }
    return Arr;
}

void PrintArr(int [] Arr)
{
    Console.Write("[");
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i]);
        if (i < Arr.Length -1) Console.Write(", ");
    }
    Console.Write("] ");
    Console.WriteLine();
}



PrintArr(new int []{1, 2, 5, 7, 19});
PrintArr(new int []{6, 1, 33});

PrintArr(GetRandomArr());
PrintArr(GetRandomArr(new Random().Next(1, 9), 0, 9999));