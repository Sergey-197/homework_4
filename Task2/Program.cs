//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет 
//количество чётных чисел в массиве

// пример

// [344 452 341 125] => 2


static void Main()
{
    Console.WriteLine("Введите размер нашего массива");
    int numbers = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    int сount = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000);
        System.Console.Write(numbers[i] + " ");
    }
    if (numbers[i] % 2 == 0)
    {
        сount++;
    }
    Console.WriteLine($"\nКоличество четных чисел в массиве: {сount}");
    {
}

