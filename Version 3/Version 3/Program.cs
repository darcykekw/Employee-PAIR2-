using System;

namespace DemoAbstraction
{
    abstract class Shape
    {
        public abstract float GetArea();
    }

    class Circle : Shape
    {
        public float Radius { get; }

        public Circle(float radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be positive.");
            Radius = radius;
        }

        public override float GetArea() => (float)Math.PI * Radius * Radius;
    }

    class Rectangle : Shape
    {
        public float Length { get; }
        public float Width { get; }

        public Rectangle(float length, float width)
        {
            if (length <= 0 || width <= 0)
                throw new ArgumentException("Length and width must be positive.");
            Length = length;
            Width = width;
        }

        public override float GetArea() => Length * Width;
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Shape circle = new Circle(5.0f);
                Console.WriteLine($"Circle area: {circle.GetArea()}");

                Shape rectangle = new Rectangle(4.0f, 6.0f);
                Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
