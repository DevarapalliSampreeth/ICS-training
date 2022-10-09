using System;

abstract class Student
{
    public string Name;
    public int StudentId;
    public float grade;

    public abstract Boolean IsPassed(float grade);

}

class UndergGraduate : Student
{
    public override bool IsPassed(float grade)
    {
        if (grade > 70.0f)
        {
            Console.WriteLine("Passed");
            return true;
        }
        else
        {
            Console.WriteLine("Failed");
            return false;
        }
    }
}
class Graduate : Student
{
    public override bool IsPassed(float grade)
    {
        if (grade > 80.0f)
        {
            Console.WriteLine("Passed");
            return true;
        }
        else
        {
            Console.WriteLine("Failed");
            return false;
        }
    }
}
class Program1
{
    public static void Main(string[] args)
    {
        Student student = new UndergGraduate();
        student.Name = "Sampreeth";
        student.StudentId = 123;
        Console.WriteLine("Enter the grade for UnderGraduate:");
        student.grade = Convert.ToSingle(Console.ReadLine());
        student.IsPassed(student.grade);

        student = new Graduate();
        student.Name = "Kowshik";
        student.StudentId = 456;
        Console.WriteLine("Enter the grade for Graduate");
        student.grade = Convert.ToSingle(Console.ReadLine());
        student.IsPassed(student.grade);

        Console.Read();
    }
}

