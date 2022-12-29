/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

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

int Task66(int M, int N)
{
    if(M == N) return M;
    return (N+Task66(M, N-1));
}

Console.WriteLine(Task66(GetNumber("M = "),GetNumber("N = ")));
Console.WriteLine(Task66(1,15));
Console.WriteLine(Task66(4,8));