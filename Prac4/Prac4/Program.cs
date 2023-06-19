using System;

class Customer
{
    private int x;
    public int X

    {
        get { return x; }
        set { x = value; }
    }
}

class Client
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.X = 10;  //write
        Console.WriteLine(customer.X);  //read
        Console.ReadLine();
    }
}