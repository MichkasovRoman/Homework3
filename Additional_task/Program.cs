// Задача “со звездочкой”: Напишите функцию, которая
//принимает одно число - высоту елочки и рисует ее в
//консоли звездочками.

string Spruce(int n)
{
    //Console.SetCursorPosition(n-1, 1);
    //Console.Write("*");
    string star = "*";
    for (int i = 1; i < n; i++)
    {
       Console.SetCursorPosition(n-1, i); 
       Console.Write(star);
    }
    return star;
}

Console.Clear();

Console.Write("Введите высоту елочки: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(Spruce(number));