using System;
class program3
{
    public static void Main(string[] args)
    {
        int a, b;
        char operation;
        Console.Write("input 1st no.  ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("input operation:  ");
        operation = Convert.ToChar(Console.ReadLine());
        Console.Write("input 2nd no. ");
        b = Convert.ToInt32(Console.ReadLine());
        if (operation == '+')
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
        else if (operation == '-')
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
        else if (operation == '*')
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
        else if (operation == '/')
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
        else
            Console.WriteLine("invalid character");
        Console.ReadLine();
    }
}
