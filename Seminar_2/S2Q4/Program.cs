/* Напишите программу, которая принимает на вход число и проверяет, кратное оно 7 и 23 */
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Multiple7And23(int number)
{
    if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Чило кратное 7 и 23");
    else  Console.WriteLine("Чило не кратное 7 и 23");
}
Multiple7And23(number);