/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/
Console.WriteLine("Введите трёхзначное число");
int nnn = Convert.ToInt32(Console.ReadLine());
if (nnn > 99 && nnn < 1000){
    Console.WriteLine(nnn % 10);
}
else{
    Console.WriteLine("Некорректное число");
}