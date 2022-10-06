using System;
class Program33
{
    public static void Main(string[] args)
    {
        string s1 = "ABC";
        string s2 = "XYZ";
        string s3 = "ABC";


        if (String.Equals(s1, s2))
            Console.WriteLine("{s1} and {s2} are same");
        else
            Console.WriteLine("{s1} and {s2} are different");

        if (String.Equals(s1, s3))
            Console.WriteLine("{s1} and {s3} are same ");
        else
            Console.WriteLine("{s1} and {s3} are different.");

        Console.ReadLine();
    }
}