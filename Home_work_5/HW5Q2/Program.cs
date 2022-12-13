/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int[] GetRandomArr(int length = 8, int randomIn = -100, int randomout = 100)
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

int OddArr(int[] arr)
{
    int result = 0;
    for (int k = 1; k < arr.Length; k += 2)
    {
        result += arr[k];
    }
    return result;
}

int[] test = new int[] {3, 7, 23, 12};
PrintArr(test);
Console.Write($" -> {OddArr(test)}");

Console.WriteLine();

int[] test2 = new int[] {-4, -6, 89, 6};
PrintArr(test2);
Console.Write($" -> {OddArr(test2)}");

Console.WriteLine();

int[] arr = GetRandomArr();
PrintArr(arr);
Console.Write($" -> {OddArr(arr)}");