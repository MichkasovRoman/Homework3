// Задача 29: Напишите программу, которая задаёт массив из 8
//элементов и выводит их на экран.

int[] Row_of_Numbers(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8)
{
    int [] ResultArray = new int[8] {n1, n2, n3, n4, n5, n6, n7, n8};
    return ResultArray;
}

Console.Clear();

Console.WriteLine("Введите 8 чисел:");
int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);
int number3 = int.Parse(Console.ReadLine()!);
int number4 = int.Parse(Console.ReadLine()!);
int number5 = int.Parse(Console.ReadLine()!);
int number6 = int.Parse(Console.ReadLine()!);
int number7 = int.Parse(Console.ReadLine()!);
int number8 = int.Parse(Console.ReadLine()!);

int[] array = Row_of_Numbers(number1,number2,number3,number4,number5,number6,number7,number8);

Console.Write(String.Join(", ", array));