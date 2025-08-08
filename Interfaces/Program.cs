namespace Interfaces
{
    interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            // Call Move() on each
            car.Move();      // Output: Car is moving
            bicycle.Move();  // Output: Bicycle is moving

            Console.ReadLine();
        }
    }
}
