/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

// int[] GetRandomArr(int length = 123, int randomIn = 9, int randomout = 100)
// {
//     int [] Arr = new int [length];
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         Arr[i] = rnd.Next(randomIn, randomout);
//     }
//     return Arr;
// }

// void PrintArr(int [] Arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Console.Write(Arr[i]);
//         if (i < Arr.Length -1) Console.Write(", ");
//     }
//     Console.Write("] ");
// }

// int ArrLength(int [] arr)
// {
//     int result = 0;
//     foreach (int k in arr) result++;
//     return result;
// }

// int[] arr = GetRandomArr();
// PrintArr(arr);
// Console.Write($" -> {ArrLength(arr)}");

int Count(int[] array, int min, int max)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= min) && (array[i] <= max))
            result++;
    }
    return result;
}

//int[] a = InitArray(23);
int[] a = {10, 11, 12, 13, 14};
Console.WriteLine(String.Join(" ", a));
Console.WriteLine(Count(a, 10, 99));
