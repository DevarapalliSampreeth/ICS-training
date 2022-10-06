using System;
class program4
{
    public static void Main(string[] args)
    {
        double c, html, sql, avg, total;
        string n, res;

        Console.Write("enter name of the Student :");
        n = Console.ReadLine();

        Console.Write("enter C# marks : ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter html marks : ");
        html = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter sql marks : ");
        sql = Convert.ToInt32(Console.ReadLine());

        total = c + html + sql;
        avg = total / 3.0;
        if (avg >= 50)
            res = "passed";
        else
            res = "failed";


        Console.Write("Name of Student : {0}\n", n);
        Console.Write("c# marks: {0}\nhtml marks: {1}\nsql marks: {2}\n", c, html, sql);
        Console.Write("Total Marks = {0}\navg = {1}\nres = {2}\n", total, avg, res);
    }
}

