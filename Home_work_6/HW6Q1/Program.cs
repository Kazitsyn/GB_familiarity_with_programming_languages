/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


int GetNumbersPositiveElements(string intText)
{
    int positiv = 0;
        string[] arr = intText.Split(' ');
        for (int i = 0; i < arr.Length; i++)
            if (Convert.ToInt32(arr[i]) > 0) positiv++;
        return positiv;
}

    Console.Write("Введите числа через пробел: ");

    string input = Console.ReadLine() ?? " ";
    
    
    Console.WriteLine($"{input} -> {GetNumbersPositiveElements(input)}");
