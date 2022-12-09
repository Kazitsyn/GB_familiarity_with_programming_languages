/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int GetLenght(int number)
{
    var count = 0;
      int num = number;
    
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine(GetLenght(12345678));