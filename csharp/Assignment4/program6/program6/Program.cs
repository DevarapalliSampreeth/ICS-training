using System;

class Doctor
{
    private int RegNo { get; set; }

    private string Name { get; set; }

    private int FeesCharged { get; set; }

    public static void Main(string[] args)
    {
        Doctor d = new Doctor();
        d.setName();
        d.getName();
        Console.Read();
    }
    public void setName()
    {
        Name = "Sampreeth";
        RegNo = 11;
        FeesCharged = 123;
    }
    public void getName()
    {
        Console.WriteLine("---Doctor fee---");
        Console.WriteLine("Name        :" + Name);
        Console.WriteLine("Register No :" + RegNo);
        Console.WriteLine("FeesCharged :" + FeesCharged);
    }
}