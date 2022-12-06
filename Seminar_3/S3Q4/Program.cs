/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

// int Cube(int x)
// {
//     if (x == 0) return 1;
//     Console.Write((x*x) + " ");
//     return Cube(x - 1);
// }

// Cube(5);

Console.WriteLine("Введите число.");

int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1;i <= number; i++)
{
    Console.Write($"{i * i}");
    if (i != number) Console.Write(", ");
}
