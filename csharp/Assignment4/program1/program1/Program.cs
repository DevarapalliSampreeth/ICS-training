using System;

class Program1
{
    public static void Main(string[] args)
    {
        Console.ReadLine();
    }
    public static void Display()
    {
        Console.WriteLine("Enter First Name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Last Name");
        string lastName = Console.ReadLine();
        Console.WriteLine("First Name " + firstName.ToUpper());
        Console.WriteLine("Last Name " + lastName.ToUpper());
        Console.ReadLine();
    }
}