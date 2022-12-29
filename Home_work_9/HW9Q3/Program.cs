/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Task68(int m, int n)
{
    if(m == 0) return n+1;
    else if(n == 0) return Task68(m-1, 1);
    else return Task68(m-1,Task68(m, n-1));
}

Console.WriteLine(Task68(2,3));
Console.WriteLine(Task68(3,2));