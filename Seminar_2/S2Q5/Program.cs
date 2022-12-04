/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого*/
Console.WriteLine("Введите первое число: ");
int number0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool SquareNumber (int number0, int number1)
{
    if (number0 * number0 == number1 || number1 * number1 == number0)return true;
    return false;
}

Console.WriteLine(SquareNumber(number0,number1));