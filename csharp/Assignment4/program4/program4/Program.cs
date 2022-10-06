using System;

class Customer
{
    int CustomerId;
    string Name;
    int Age;
    int Phone;
    string City;
    public static void Main(string[] args)
    {
        Console.WriteLine("---------Customer Details---------");
        Customer c1 = new Customer(123, "Sampreeth", 21, 1234567890, "Srikakulam");
        DisplayCustomer(c1);

    }
    public Customer()
    {

    }
    public Customer(int CustomerId, string Name, int Age, int Phone, string City)
    {
        this.CustomerId = CustomerId;
        this.Name = Name;
        this.Age = Age;
        this.Phone = Phone;
        this.City = City;
    }
    public static void DisplayCustomer(Customer customer)
    {
        Console.WriteLine("Customer Id  : " + customer.CustomerId);
        Console.WriteLine("Customer Name: " + customer.Name);
        Console.WriteLine("Customer Age : " + customer.Age);
        Console.WriteLine("Phone Number : " + customer.Phone);
        Console.WriteLine("Customer City: " + customer.City);
    }
    ~Customer()
    {
        Console.WriteLine("***DESTRUCTOR***");
        Console.ReadLine();
    }
}