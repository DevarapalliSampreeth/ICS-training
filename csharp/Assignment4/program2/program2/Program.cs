using System;
using System.Linq;

class program2
{
    public static void Main(string[] args)
    {
        string str = "oops programing";
        char ch = 'o';

        int freq = str.Count(f => (f == ch));
        Console.WriteLine(freq);
        Console.ReadLine();
    }
}