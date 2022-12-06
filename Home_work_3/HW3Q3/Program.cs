/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


void NumberCube(int N)
{
    Console.Write($"{N} -> ");
    for(int i = 1;i <= N; i++)
    {
        Console.Write($"{i * i * i}");
        if (i != N) Console.Write(", ");
        else Console.WriteLine();
    }
}

NumberCube(3);
NumberCube(5);

NumberCube(new Random().Next(1, 20));
