/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message)
{
    double result;
    while(true)
    {
        Console.Write(message);

        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

(double, double) GetIntersectionTwoLines(double k1 = 0, double b1 = 0, double k2 = 0, double b2 = 0)
{
      
    double x =  (b2 - b1) / (k1 - k2);
    double y =  (b1*k2 - b2*k1) / (k2 - k1);
    return ( x , y );
}

Console.WriteLine("Введите переменные k и b координат первой и второй прямой (y = k * x + b)");


double k1 = GetNumber("k1 = ");
double b1 = GetNumber("b1 = ");
double k2 = GetNumber("k2 = ");
double b2 = GetNumber("b2 = ");

(double x, double y) = GetIntersectionTwoLines(k1, b1, k2, b2);

Console.WriteLine($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> ({x}; {y})");