using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Student
    {
        public int id;
        public string name;

        public void insert(int i, string n)
        {
            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine(id + " " + name);
        }

    }


    class TestStudent
    {
        public static void Main(String[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.insert(101, "diya");
            s2.insert(102, "riya");
            s1.display();
            s2.display();
            Console.ReadLine();

        }
    }
}