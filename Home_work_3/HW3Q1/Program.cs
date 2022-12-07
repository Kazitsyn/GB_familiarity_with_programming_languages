/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int GetIndex(int number, int index = 0)
{
    int count = Convert.ToString(number).Length;
    if (index < count)
    {
        int result = -1;
        int del = 1;
        int ost = 10;

            for (int i = 0; i <= index; i++)
            {
                result = (number % ost) / del;
                ost *= 10;
                del *= 10;
            }
            return result;
    }
    else return -1;
}



bool Palindrome(int number)
{
    if (GetIndex(number) == GetIndex(number, 4) && GetIndex(number, 1) == GetIndex(number, 3))
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