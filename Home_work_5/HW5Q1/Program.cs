/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] GetRandomArr(int length = 8, int randomIn = 100, int randomout = 1000)
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
}

int EvenArr(int[] arr)
{
    int result = 0;
    foreach (int k in arr) 
    {
        if (k % 2 == 0) result++;
    }
    return result;
}

int[] test = new int[] {345, 897, 568, 234};
PrintArr(test);
Console.Write($" -> {EvenArr(test)}");

Console.WriteLine();

int[] arr = GetRandomArr();
PrintArr(arr);
Console.Write($" -> {EvenArr(arr)}");