/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. */

int GetRandomNumber()
{
    return new Random().Next(100, 1000); // 100 ... 1000
}

void ShowRandomNumberString(int number)
{
    Console.WriteLine($"Случайное число: {number}");
    string str = number.ToString();
    Console.WriteLine($"> {str[0]}{str[2]}");
}
ShowRandomNumberString(GetRandomNumber());

int ShowRandomNumber(int number)
{
    Console.WriteLine($"Случайное число: {number}");
    return ((number / 100)*10)+(number % 10);
}
Console.WriteLine(ShowRandomNumber(GetRandomNumber()));
