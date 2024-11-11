class Program
{
    static void Main()
    {
        try
        {
            Circle circle = new Circle(5.0f);
            Console.WriteLine($"Circle area with radius {circle.Radius}: {circle.GetArea()}");

            circle.Radius = -3;
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Rectangle rectangle = new Rectangle(4.0f, 6.0f);
            Console.WriteLine($"Rectangle area with length {rectangle.Length} and width {rectangle.Width}: {rectangle.GetArea()}");

            rectangle.Width = -2;
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}