//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string Method(int quarter)
{
    if(quarter > 0 && quarter < 5)
    {
        switch (quarter)
        {
            case 1:
            return "x = 0 ... + ∞ \n y = 0 ... + ∞[x+∞]";
            case 2:
            return "x = 0 ... - ∞ \n y = 0 ... + ∞[x+∞]";
            case 3:
            return "x = 0 ... - ∞ \n y = 0 ... - ∞[x+∞]";
            case 4:
            return "x = 0 ... + ∞ \n y = 0 ... - ∞[x+∞]";
            default:
            return "нужно ввести число от 1 до 4";
        }
        
    }
    else return "нужно ввести число от 1 до 4";
}

Console.WriteLine(Method(1));