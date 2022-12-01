/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

void EvenSequence(int N)
    {
    if (N >= 1)
        {
        for(int i = 1; N >= i; i++)
            {
            if (i % 2 == 0)
                {
                Console.Write(i);
                if(i > 1 && i < N-1) Console.Write(", ");
                } 
            }
        }
    Console.WriteLine();
    }

EvenSequence(5);
EvenSequence(8);

// Console.WriteLine("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// EvenSequence(N);

