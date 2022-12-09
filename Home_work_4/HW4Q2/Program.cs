/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */


int SumIndex(int number)
{
    int count = Convert.ToString(number).Length;
    int result = 0;
    int del = 1;
    int ost = 10;

        for (int i = 0; i <= count; i++)
        {
            result += (number % ost) / del;
            ost *= 10;
            del *= 10;
             
        }
    return result;
}

void PrintSumIndex(int number)
{
    Console.WriteLine($"{number} -> {SumIndex(number)}");
}

PrintSumIndex(452);
PrintSumIndex(82);
PrintSumIndex(9012);

PrintSumIndex(new Random().Next(1, 999999999));



