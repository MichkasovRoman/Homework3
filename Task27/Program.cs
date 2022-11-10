// Задача 27: Напишите функцию и запустите ее, которая
//принимает на вход число и выдаёт сумму цифр в числе.

int Sum_of_Digits(int n)
{
    int sum = 0;
    while (n != 0)
    {
        sum = sum + Math.Abs(n%10);
        n = n/10;
    }
    return sum;
}

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр введенного вами числа равна {Sum_of_Digits(number)}");
