/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int Pow(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}

void PrintPow(int A, int B)
{
    Console.WriteLine($"{A}, {B} -> {Pow(A, B)}");
}

PrintPow(3, 5);
PrintPow(2, 5);

PrintPow(new Random().Next(1, 10), new Random().Next(1, 10));
