using System;

namespace lesson10_1
{
    

    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[2];


            shapes[0] = new Rectangle(7, 10);
            shapes[1] = new Circle(6);


            foreach (var var in shapes)
            {
                Console.WriteLine("Area of the shape: " + var.Area());
                Console.WriteLine("Perimeter of the shape: " + var.Perimeter());
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }

    class Rectangle : Shape
    {
        public double part1, part2;

        public Rectangle(double part1, double part2)
        {
            this.part1 = part1;
            this.part2 = part2;
        }

        public override double Area()
        {
            return part1 * part2;
        }

        public override double Perimeter()
        {
            return 2 * (part1 + part2);
        }
    }


    class Shape
    {
        public virtual double Area()
        {
            return 0.000;
        }

        public virtual double Perimeter()
        {
            return 0.000;
        }
    }
    class Circle : Shape
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

    }

}
