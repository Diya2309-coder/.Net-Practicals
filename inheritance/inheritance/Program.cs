using System;
namespace InheritanceApplication
{
    class Shape
    {

        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w; 
        }
        public void setHeight(int h)
        {
            height = h;
        }

    }
    class Rectangle : Shape
    {
        public int getArea()
        {
        return width * height;
        }
    }

    class RectangleTester
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle= new Rectangle();
            rectangle.setWidth(10);
            rectangle.setHeight(10);
            Console.WriteLine("total area : {0}",rectangle.getArea());
            Console.ReadLine();
        }
    }
}