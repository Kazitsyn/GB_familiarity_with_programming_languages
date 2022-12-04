/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/



string DayOff(int day)
{
    if (day < 8 && day > 0)
        {
            if (day < 6 && day > 0)return "нет";
            else return "да"; 
        }
    else return "в неделе всего 7 дней";
}

Console.WriteLine($"6 -> {DayOff(6)}");
Console.WriteLine($"7 -> {DayOff(7)}");
Console.WriteLine($"1 -> {DayOff(1)}");

int randomDay = new Random().Next(1, 8);
Console.WriteLine($"Random day: {randomDay} -> {DayOff(randomDay)}");