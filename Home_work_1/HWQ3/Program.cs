/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console. WriteLine("Введите чило: ");
int number0 = Convert.ToInt32(Console.ReadLine());
if (number0 % 2 == 0){
    Console.WriteLine("Четное");
} else {
    Console.WriteLine("Не четное");
}