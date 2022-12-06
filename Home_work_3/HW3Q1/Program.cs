/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int GetIndex(int number, int index)
{
    switch (index)
    {
        case 0:
        return number / 10000;
        case 1:
        return (number / 1000) % 10;
        case 3:
        return (number % 100) / 10;
        case 4: 
        return number % 10;
        default:
        return -1;
    }
}

bool Palindrome(int number)
{
    if (GetIndex(number, 0) == GetIndex(number, 4) && GetIndex(number, 1) == GetIndex(number, 3))
    {
        return true;
    }
    else return false;
}

void Print(int number, bool palindrome)
{
    if (palindrome == true)
    {
        Console.WriteLine($"{number} -> да");
    }
    else Console.WriteLine($"{number} -> нет");
}



Print(14212, Palindrome(14212));
Print(12821, Palindrome(12821));
Print(23432, Palindrome(23432));

int number = new Random().Next(10000, 99999);
Print(number, Palindrome(number));