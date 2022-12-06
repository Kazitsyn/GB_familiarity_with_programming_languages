/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

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

int x1 = GetNumber("Введите координату х1:");
int x2 = GetNumber("Введите координату х2:");
int y1 = GetNumber("Введите координату y1:");
int y2 = GetNumber("Введите координату y2:");

double DistXY (int x1, int x2, int y1, int y2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2));
    return result;
}

Console.WriteLine($"Растояние между точками {DistXY(x1,x2,y1,y2)}");
