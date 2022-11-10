// Задача 29: Напишите программу, которая задаёт массив из 8
//элементов и выводит их на экран.

int[] Row_of_Numbers()
{
    int [] ResultArray = new int[8];
    for (int i = 0; i <= 7; i++)
    {
        Console.WriteLine($"Введите {i}-й элемента массива:");
        ResultArray[i] = int.Parse(Console.ReadLine()!);
    }
    return ResultArray;
}

Console.Clear();

int[] array = Row_of_Numbers();
Console.Write($"Полученный массив: [{String.Join(", ", array)}]");