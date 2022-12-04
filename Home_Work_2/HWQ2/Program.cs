/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void ThirdDigit(int number)
{
    string str = number.ToString();
    if (str.Length > 2) Console.WriteLine($"{number} -> {str[2]}");
    else Console.WriteLine($"{number} -> третьей цифры нет");
}

ThirdDigit(645);
ThirdDigit(78);
ThirdDigit(32679);
ThirdDigit(new Random().Next(0, 100000)); //Random 0...100000
