/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число");
        }
    }

    return result;
}




double DistXY (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2) + Math.Pow((z1-z2), 2));
    return result;
}

Console.Write($"A (3,6,8); B (2,1,-7), -> {DistXY(x1: 3, y1: 6, z1: 8, x2: 2, y2: 1, z2: -7)}\n");
Console.Write($"A (7,-5, 0); B (1,-1,9) -> {DistXY(x1: 7, y1: -5, z1: 0, x2: 1, y2: -1, z2: 9)}\n");



int x1 = GetNumber("Введите координату х1:");
int y1 = GetNumber("Введите координату y1:");
int z1 = GetNumber("Введите координату z1:");
int x2 = GetNumber("Введите координату х2:");
int y2 = GetNumber("Введите координату y2:");
int z2 = GetNumber("Введите координату z2:");
Console.WriteLine($"Растояние между точками {DistXY(x1,x2,y1,y2,z1,z2)}");