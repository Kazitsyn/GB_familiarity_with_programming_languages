/*
40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

// int GetNumber(string message)
// {
//     int result;
//     while(true)
//     {
//         Console.WriteLine(message);

//         if(int.TryParse(Console.ReadLine(), out result))
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не число.");
//         }
//     }

//     return result;
// }

bool doCalculation(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}


int a = 3;
int b = 3;
int c = 3;

Console.WriteLine($"Стороны: {a}, {b}, {c}");

string ne = doCalculation(a, b, c) ? "" : " не";

Console.WriteLine($"Треугольник{ne} может существовать");
