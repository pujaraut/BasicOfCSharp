using System;

namespace AbstractImplementation
{
    public abstract class Figure
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }

    }

    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;

        }

        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }

    public class TestFigures : Figure
    {
        public TestFigures(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    public class Test
    { 
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);
            Cone co = new Cone(34.98, 12.98);
            TestFigures tf = new TestFigures(5,5);

            Console.WriteLine("Area of Rectangle: {0}", r.GetArea());
            Console.WriteLine("Area of Circle: {0}", c.GetArea());
            Console.WriteLine("Area of Cone: {0}", co.GetArea());
            Console.WriteLine("Area of TestFigures: {0}", tf.GetArea());
        }
    }

}
     

