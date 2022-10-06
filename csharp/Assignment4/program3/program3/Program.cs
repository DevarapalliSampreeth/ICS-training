using System;

class SalesDetails
{
    int SalesNo, ProductNo, Quatinty;
    float Price, TotalAmount;
    string DateOfSale;

    public static void Main(string[] args)
    {
        SalesDetails s = new SalesDetails(11, 123, 456.78f, 9, "24th jan 2001");
        s.Sales(s.Quatinty, s.Price);
        s.ShowData();
        Console.Read();
    }
    public SalesDetails(int SalesNo, int ProductNo, float Price, int Quatinty, string DateOfSale)
    {
        this.SalesNo = SalesNo;
        this.ProductNo = ProductNo;
        this.Price = Price;
        this.Quatinty = Quatinty;
        this.DateOfSale = DateOfSale;
    }
    public float Sales(int Quatinty, float Price)
    {
        TotalAmount = Quatinty * Price;
        return TotalAmount;
    }
    public void ShowData()
    {
        Console.WriteLine("------Sales Details------");
        Console.WriteLine("Sales Number   : " + SalesNo);
        Console.WriteLine("Product Number : " + ProductNo);
        Console.WriteLine("Price          : " + Price);
        Console.WriteLine("Quantity       : " + Quatinty);
        Console.WriteLine("Date Of Sale   : " + DateOfSale);
        Console.WriteLine("Total Amount   : " + TotalAmount);
    }
}