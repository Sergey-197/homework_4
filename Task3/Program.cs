// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

void Main()
{

    int[] numbers = { 1, 3, 5, 6, 7, 8 };
    int temp;

    Console.Write("Исходный массив: ");

    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
    }
    Console.Write("\nПеревернутый массив: ");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
  