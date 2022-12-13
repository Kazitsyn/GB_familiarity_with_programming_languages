/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

bool NumsExist1(int [] arr, int target)
{
    foreach (int k in arr)
    {
        if (k == target) return true;
    }
    return false;
}

void NumsExists(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            Console.WriteLine($"Число {target} присутствует в массиве.");
            return;
        }
    }
    Console.WriteLine("Не нашел");
}

NumsExists(array: new int[] {2, 4, 3, 1}, target: 76);
