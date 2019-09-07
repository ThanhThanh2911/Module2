using System;

namespace Shapes
{
    class Shapes
    {
        private Location c;
        public string ToString()
        {
            return "Shape";
        }
        double area;
        public double Area()
        {
            return 0.00;
        }
        public double Perimeter()
        {
            return 0.00;
        }
        public class Rectangle: Shapes
        {
            private double side1;
            private double side2;

            public double Side1 { get => side1; set => side1 = value; }
            public double Side2 { get => side2; set => side2 = value; }
            public double Area()
            {
                return Side1 * Side2;
            }
            public double Perimeter()
            {
                return (Side1 + Side2) * 2;
            }
        }
        public class Circle: Shapes
        {
            private double radius;

            public double Radius { get => radius; set => radius = value; }
        }
        public class Location: Shapes
        {
            private double x, y;

            public double X { get => x; set => x = value; }
            public double Y { get => y; set => y = value; }
        }
        class TestShape
        {
            static void Main()
            {
                Circle circle1 = new Circle();
                Rectangle rectangle1 = new Rectangle();
                rectangle1.Side1 = 12;
                rectangle1.Side2 = 10;
                Console.WriteLine(rectangle1.Area());
                Shapes shapes1 = new Shapes();
                Console.WriteLine(shapes1.Area());

            }
        }
    }
}
