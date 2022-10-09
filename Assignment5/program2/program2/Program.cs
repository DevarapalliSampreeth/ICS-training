using System;

class PassangerException : ApplicationException
{
    public string Name;
    public int Age;
    public PassangerException(string msg) : base(msg)
    {
        Console.WriteLine("Enter the Name : ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter the Age : ");
        Age = Convert.ToInt32(Console.ReadLine());
    }
    public void TicketBooking()
    {
        int tickets;
        Console.WriteLine("Enter the no.of Tickets");
        tickets = Convert.ToInt32(Console.ReadLine());
        if (tickets > 2)
        {
            Console.WriteLine("can not book more than 2 tickets");
        }
        else
            Console.WriteLine("Tickets Booked Successfully");
    }
    class passanger
    {
        public static void Main(string[] args)
        {
            PassangerException pass = new PassangerException("message");
            try
            {
                pass.TicketBooking();
            }
            catch (PassangerException p)
            {
                Console.WriteLine(p.Message);
            }
            Console.ReadLine();

        }

    }

}

