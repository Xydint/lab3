using System;

class Program
{
    public static void Main(string[] args)
    {
        RomanNumber number1 = new RomanNumber((ushort)2419), number2;
        Console.WriteLine(number1);
        Console.WriteLine("ЧИСЛА: \n");
        number1 = new RomanNumber((ushort)30);
        Console.WriteLine(number1);
        number2 = new RomanNumber((ushort)15);
        Console.WriteLine(number2);
        Console.WriteLine("Операции на числами: \n");
        try
        {
            Console.WriteLine("Сложение: "); Console.WriteLine(number1 + number2);
            Console.WriteLine("Вычитание: "); Console.WriteLine(number1 - number2);
            Console.WriteLine("Умножение: "); Console.WriteLine(number1 * number2);
            Console.WriteLine("Деление: "); Console.WriteLine(number1 / number2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("\n");
        Console.WriteLine("Сортировка: \n");
        Random rnd = new Random(DateTime.Now.Millisecond);
        RomanNumber[] R = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            R[i] = new RomanNumber((ushort)(30 + rnd.Next(20)));
        }
        Array.Sort(R);
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(R[i]);
        }
        Console.ReadLine();
    }
}