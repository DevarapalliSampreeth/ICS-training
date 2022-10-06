using System;
class program2
{
   public static void Main(string[] args)
    {
        Console.WriteLine("enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("number is positive");
        }
        else
        {
            Console.WriteLine("number is negative");
        }
    }
}