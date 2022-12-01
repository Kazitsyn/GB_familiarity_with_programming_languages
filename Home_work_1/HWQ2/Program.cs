/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int Max(int arg1, int arg2, int arg3)
    {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
    }

Console.WriteLine(Max(2, 3, 7));
Console.WriteLine(Max(44, 5, 78));
Console.WriteLine(Max(22, 3, 9));


// Console. WriteLine("Введите первое чило: ");
// int number0 = Convert.ToInt32(Console.ReadLine());
// Console. WriteLine("Введите второе чило: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console. WriteLine("Введите третье чило: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Максимальное введеное чило = " + Max(number0, number1, number2));