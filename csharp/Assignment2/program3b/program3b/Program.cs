using System;
class program32
{
    public static void Main(string[] args)
    {
        string str = "", reverse = "";
        int Length = 0;

        Console.WriteLine("Enter a word: ");
        str = Console.ReadLine();
        Length = str.Length - 1;
        while (Length >= 0)
        {
            reverse = reverse + str[Length];
            Length--;
        }
        Console.WriteLine("reverse of word is {0}", reverse);
        Console.ReadLine();
    }
}

