
using System;
class program1
{
    public static void Main(string[] args)
    {
        int a, b;

        Console.Write("enter 1st number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter 2nd number: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a == b)
            Console.WriteLine("{0} and {1} are equal.\n", a, b);
        else
            Console.WriteLine("{0} and {1} are not equal.\n", a, b);

        Console.Read();
    }
}