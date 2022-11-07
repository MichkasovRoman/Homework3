// Задача “со звездочкой”: Напишите функцию, которая
//принимает одно число - высоту елочки и рисует ее в
//консоли звездочками.

string Spruce(int n)
{
    string star = "*";
    for (int i = 1; i < n; i++)
    {
        Console.WriteLine(" " + star);
        star = "*" + star + "*";
    }
    return star;
}

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(Spruce(number));