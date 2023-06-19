using System;

class GFG
{
    /* Function to get sum of digits */
    static int getSum(int n)
    {
        int sum = 0;
       
        while (n != 0)
        {
            sum = sum + n % 10;
            n = n / 10;
        }

        return sum;
    }

    // Driver code
    public static void Main()
    {
        int n = 687;
        Console.WriteLine("sum of digit is : " + getSum(n));

    }
}