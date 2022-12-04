/* Напишите программу, которая будет принимать на вход два числа и выводить является ли второе число кратное первому. 
Если не является то выводить остаток от деления */
void Multiple(int number0, int number1)
{
    int result = number0 % number1;
    if (result == 0) Console.WriteLine("Число 1 кратное числу 2");
    else Console.WriteLine(result);
}
Multiple(555, 5);