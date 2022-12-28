/*
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не чило");
        }
    }
    return result;
}

int Fact(int n)
{
    if (n == 0)
    {
        return 1;
    }
    return n*Fact(n-1);
}

void Pasc(int n)
{
    for (int i = 0; i < n; i++)
        {
            for (int c = 0; c <= (n - i); c++) 
            {
                Console.Write(" "); 
            }
            for (int c = 0; c <= i; c++)
            {
                Console.Write(" "); 
                Console.Write(Fact(i) / (Fact(c) * Fact(i - c))); 
            }
            Console.WriteLine(); 
        }
    Console.ReadLine();    
}

Pasc(GetNumber("Введите N строк треугольника Паскаля: "));