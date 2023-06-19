using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculate
{
    class Student
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter student roll no : ");
            int roll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the name of student : ");
            string name = Console.ReadLine();
           
            Console.WriteLine("enter the marks of physics : ");
            string physics = Console.ReadLine();
            int phy = Int32.Parse(physics);

            Console.WriteLine("enter the marks of chemistry : ");
            string chemistry = Console.ReadLine();
            int che = Int32.Parse(chemistry);

            Console.WriteLine("enter the marks of maths : ");
            string maths = Console.ReadLine();
            int math = Int32.Parse(maths);

            int total = phy + che + math;
            double percentage = total / 3.0;

            Console.WriteLine(" Total : " + total);
            Console.WriteLine(" Percentage : " + percentage);

            if (percentage <= 35)
            { 
                Console.WriteLine(" Grade is F ");
            }
            else if (percentage >= 34 && percentage <= 39)
            {
                Console.WriteLine(" Grade is D ");
            }
            else if (percentage >= 40 && percentage <= 59)
            {
                Console.WriteLine(" Grade is C ");
            }
            else if (percentage >= 60 && percentage <= 69)
            {
                Console.WriteLine(" Grade is B ");
            }
            else if (percentage >= 70 && percentage <= 79)
            {
                Console.WriteLine(" Grade is B+ ");
            }
            else if (percentage >= 80 && percentage <= 90)
            {
                Console.WriteLine(" Grade is A ");
            }
            else if (percentage >= 91)
            {
                Console.WriteLine(" Grade is A+ ");
            }


        }
    }
}