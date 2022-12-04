# Знакомство с языком программирования С#
## Домашняя работа № 2 [GitHub](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_Work_2)
***
### **Задача 10:** *Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*

* 456 -> 5

* 782 -> 8

* 918 -> 1

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_Work_2/HWQ1)
```c#
int Dozens(int xyz)
{
    return (xyz % 100)/10;
}

Console.WriteLine($"456 -> {Dozens(456)}");
Console.WriteLine($"782 -> {Dozens(782)}");
Console.WriteLine($"918 -> {Dozens(918)}");

int xyz = new Random().Next(100, 1000); 
Console.WriteLine($"Random: {xyz} -> {Dozens(xyz)}");
```
Вывод консоли:
```c#
456 -> 5
782 -> 8
918 -> 1
Random: 669 -> 6
```
***
### **Задача 13:** *Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*

* 645 -> 5

* 78 -> третьей цифры нет

* 32679 -> 6

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_Work_2/HWQ2)
```c#
void ThirdDigit(int number)
{
    string str = number.ToString();
    if (str.Length > 2) Console.WriteLine($"{number} -> {str[2]}");
    else Console.WriteLine($"{number} -> третьей цифры нет");
}

ThirdDigit(645);
ThirdDigit(78);
ThirdDigit(32679);
ThirdDigit(new Random().Next(0, 100000)); 
```
Вывод консоли:
```c#
645 -> 5
78 -> третьей цифры нет
32679 -> 6
64486 -> 4
```
***
### **Задача 15:** *Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*

* 6 -> да

* 7 -> да

* 1 -> нет

[Решение:](https://github.com/Kazitsyn/GB_familiarity_with_programming_languages/tree/main/Home_Work_2/HWQ3)
```c#
string DayOff(int day)
{
    if (day < 8 && day > 0)
        {
            if (day < 6 && day > 0)return "нет";
            else return "да"; 
        }
    else return "в недели всего 7 дней";
}

Console.WriteLine($"6 -> {DayOff(6)}");
Console.WriteLine($"7 -> {DayOff(7)}");
Console.WriteLine($"1 -> {DayOff(1)}");
int randomDay = new Random().Next(1, 8);
Console.WriteLine($"Random day: {randomDay} -> {DayOff(randomDay)}");
```
Вывод консоли:
```c#
6 -> да
7 -> да
1 -> нет
Random day: 3 -> нет
```
***