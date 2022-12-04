/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int Dozens(int xyz)
{
    return (xyz % 100)/10;
}

Console.WriteLine($"456 -> {Dozens(456)}");
Console.WriteLine($"782 -> {Dozens(782)}");
Console.WriteLine($"918 -> {Dozens(918)}");

int xyz = new Random().Next(100, 1000); // [100 ... 1000)
Console.WriteLine($"Random: {xyz} -> {Dozens(xyz)}");