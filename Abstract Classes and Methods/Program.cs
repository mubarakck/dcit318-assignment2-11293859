namespace Abstract_Classes_and_Methods
{
    // Abstract base class
    abstract class Shape
    {
        // Abstract method (no body)
        public abstract double GetArea();
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement the abstract method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Implement the abstract method
        public override double GetArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Circle and Rectangle objects
            Shape circle = new Circle(9);       // radius = 9
            Shape rectangle = new Rectangle(10, 3); // length = 10, width = 3

            // Display their areas
            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

            Console.ReadLine();
        }
    }
}
