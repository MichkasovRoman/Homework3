// Задача 25: Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную
//степень B.

void A_to_Power_of_B (int A, int B)
{
    if (B > 0)
    {
        int result = 1;
        for (int i = 1; i <= B; i ++)
        {
          result = result*A;  
        }
        Console.WriteLine($"Результат возведения {A} в степень числа {B} равен {result}");
    } 
    
    else
    {
        Console.WriteLine($"Число {B} не является натуральным.");
        Console.WriteLine("Перезапустите программу и введите числа еще раз.");
    }
}

Console.Clear();
Console.Write("Введите число A = ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B = ");
int numb2 = int.Parse(Console.ReadLine()!);
A_to_Power_of_B(numb1, numb2);