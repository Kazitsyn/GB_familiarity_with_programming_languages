/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

string Even(int number)
    {
    if (number % 2 == 0) return "да";  
    return "нет";
    }

Console.WriteLine(Even(4));
Console.WriteLine(Even(-3));
Console.WriteLine(Even(7));

// Console. WriteLine("Введите чило: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Even(number));

