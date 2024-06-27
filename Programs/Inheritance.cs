using System;
class hello
{
    public static void Main(string[] args)
    {
        Console.WriteLine("**** Inheritance Example ****");
        Shapes shape = new Shapes();
        Triangle triangle = new Triangle();
        Rectangle rectangle = new Rectangle();
        Square square= new Square();
        shape.length = 10;
        shape.breadth = 20;
        shape.height = 30;
        Console.WriteLine("  Area of Triangle :: " + triangle.Area_Triangle(shape.height, shape.breadth));
        Console.WriteLine("  Area of Rectangle :: " + rectangle.Area_Rectangle(shape.length, shape.breadth));
        Console.WriteLine("  Area of Square :: " +square.Area_Square(shape.length));

    }
    class Shapes
    {
        public double height, length, breadth;
    }

    class Triangle : Shapes
    {
        double area;
        public double Area_Triangle(double height, double breadth)
        {
            area = 0.5 * height * breadth;
            return area;
        }
    }

    class Rectangle : Shapes
    {
        double area;
        public double Area_Rectangle(double length, double breadth)
        {
            area = length * breadth;
            return area;
        }
    }

    class Square : Shapes{
        double area;
        public double Area_Square(double length){
            area = length * length;
            return area;
        }
    }

}