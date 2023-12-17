// Напишите программу, которая бесконечно запрашивает
// целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или 
//при вводе числа, сумма цифр которого четная

//Пример
//5 12 16 q [STOP] 
//3 45 342 15 [STOP]


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num;
int sum = 0;
    while (result > 0) 
    {
    sum = sum + result % 10;
    result = result / 10;
    }
    for (int i = 0; ; i++)
    {
    Console.Write("Введите число");
    string stop = Console.ReadLine();

    if (stop == "q")
    {
        break;
    }
    if (sum%2 == 0)
    {
        break;
    }
}


 

// for (int i = 0; ; i++)
// {
//     Console.Write("Введите число");
//     string stop = Console.ReadLine();
 
//     if (stop == "q")
//     {
//         break;
//     }
//     int num = Convert.ToInt32(stop);
//     int sum = 0;
//     int copyNum = num;

//     while (copyNum > 0)
//     {
//         sum = sum + copyNum % 10;
//         copyNum = copyNum / 10;
//     }
//      if (sum % 2 == 0)
//     {
//         break;
//     }
// }    






















