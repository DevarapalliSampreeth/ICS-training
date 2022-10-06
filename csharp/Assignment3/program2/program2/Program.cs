using System;
class Student
{
    public static void Main(string[] args)
    {
        Student s1 = new Student(123, "ABC", "1", "CSE", "1");
        s1.Getmarks();
        s1.DisplayResult();
        s1.DisplayData();
        Console.ReadLine();
    }

    int rollNum;
    string name, year, branch, sem, result;
    int[] mark = new int[5];
    int avg, Total, Count = 0;
    public Student(int rollNum, string name, string year, string branch, string sem)
    {
        this.rollNum = rollNum;
        this.name = name;
        this.year = year;
        this.branch = branch;
        this.sem = sem;

    }
    public void Getmarks()
    {
        Console.WriteLine("Enter the marks");
        for (int i = 0; i < mark.Length; i++)
        {
            Console.WriteLine("enter the marks for subject{0}: ", i + 1);
            mark[i] = Convert.ToInt32(Console.ReadLine());
            if (mark[i] < 35)
            {
                Count++;
            }

            Total = mark[i] + Total;
        }
        Console.WriteLine("Total of given marks : " + Total);
    }
    public void DisplayResult()
    {
        avg = Total / mark.Length;

        if (Count > 0 && avg < 50)
        {
            result = "failed";
        }
        else
        {
            result = "passed";
        }


    }

    public void DisplayData()
    {
        Console.WriteLine("-----student details-----");
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Roll Number: " + rollNum);
        Console.WriteLine("Year: " + year);
        Console.WriteLine("Branch: " + branch);
        Console.WriteLine("Semester: " + sem);
        Console.WriteLine("Result is: " + result);
    }

}
