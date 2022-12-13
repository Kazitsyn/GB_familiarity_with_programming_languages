/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// Получить рандомный массив вещественных чисел по умолчанию (длина 6, рандом от 0 до 100)
double [] GetRandomArr(int length = 6,  int maxR = 100)
{
    double [] Arr = new double [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        Arr[i] = rnd.NextDouble() * maxR;
    }
    return Arr;
}

// Вывести массив в квадратных скобках вещественных чисел (2 знака после запятой)
void PrintArr(double [] Arr)
{
    Console.Write("[");
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write("{0:F2}", Arr[i]);
        if (i < Arr.Length -1) Console.Write(" ");
    }
    Console.Write("] ");
}

//Получить мин и макс массива вещественных чисел
 (double, double) GetMinMaxArr(double[] arr)
{
    double min = arr[0];
    double max = 0;
    foreach (double k in arr)
    {
        if (k < min) min = k;
        if (k > max) max = k;
    }
    return  (min, max);
}

double[] test = new double[] {3, 7, 22, 2, 78};
(double min , double max) = GetMinMaxArr(test);
Console.Write($"[3, 7, 22, 2, 78] -> ");
Console.WriteLine(max - min);

double[] arr = GetRandomArr();
PrintArr(arr);
(double minArr, double maxArr) = GetMinMaxArr(arr);
Console.WriteLine(" -> {0:F2}", (maxArr - minArr));
