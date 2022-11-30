/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите чило от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1){
    
for(int i = 1; number >= i; i++){

    
    if (i % 2 == 0){
        Console.Write(i);
        if(i > 1 && i < number-1){
        Console.Write(", ");
        }
    } 
    
}
} else {
    Console.WriteLine("Неправильное число");
}