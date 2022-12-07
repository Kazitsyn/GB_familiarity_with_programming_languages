// // вид 1
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }
// Method1();

// // вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4);

// //вид 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// // вид 4

// // string Method4(int count, string c)
// // {
// //     int i = 0;
// //     string result = String.Empty;

// //     while ( i < count)
// //     {
// //         result = result + c;
// //         i++;
// //     }
// //     return result;
// // }

// string Method4(int count, string c)
// {
   
//     string result = String.Empty;

//     for (int i=2; i <= count; i++ )
//     {
//         for (int j = 2; j <= count; j++)
//         {
//             Console.WriteLine($"{i} * {j} = {i*j}");
//         }
//         Console.WriteLine();
//     }
//     return result;
// }
// string res = Method4(10, "qwerty");
// Console.WriteLine(res);

// /* Работа с текстом
// Дан текст. В тексте все пробелы заменить черточками
// маленькие буквы "к" заменить большими
// а большие "С" заменить маленькими */

// string text = "- Я думаю, - сказал князь улыбаясь, что "
//             + "ехали бы вас послали вместо нашего милого Винценгероду"
//             + "вы бы взяли приступом согласие прусского короля, "
//             + "Вы так красноречивы, Вы дадите мне чая?";

// string Replace(string text, char oldValue, char newValue )
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for ( int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
        
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');

// // Console.WriteLine(newText);
// // Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// // Console.WriteLine(newText);
// // Console.WriteLine();
// // newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1} ;

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// PrintArray(arr);

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort(arr);
PrintArray(arr);