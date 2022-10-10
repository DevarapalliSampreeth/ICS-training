
using System;

class Concession
{
    public void CalculateConcession()
    {
        string Name;
        Console.WriteLine("Enter a Name");
        Name = Convert.ToString(Console.ReadLine());

        int AgeOfPassanger;
        double TotalFare = 500;
        Console.WriteLine("Enter Age");
        AgeOfPassanger = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < AgeOfPassanger; i++)
        {
            if (AgeOfPassanger <= 5)
            {
                Console.WriteLine("Little Champs- Free Ticket");
            }
            else if (AgeOfPassanger > 60)
            {
                TotalFare = 30 * 500 / 100;
                Console.Write("TotalFare = {0}\n", TotalFare);
                Console.WriteLine("Senior Citizen");
            }
            else
            {
                Console.WriteLine("TotalFare: 500 ");
                Console.WriteLine("Ticket Booked");
            }
            Console.ReadLine();
        }

    }

}
class program
{
    public static void Main(string[] args)
    {
        Concession cn = new Concession();
        cn.CalculateConcession();
    }
}
