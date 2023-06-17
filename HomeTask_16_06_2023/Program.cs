namespace HomeTask_16_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //circle parameters

            Circle circle = new Circle();

            circle.Radius = 10;

            double circleLength = circle.Length();
            Console.WriteLine("\nCircle length: " + circleLength);

            double circleSurface = circle.Surface();
            Console.WriteLine("Circle surface: " + circleSurface);

            // Square parametrs

            Square square = new Square();

            square.Side = 5;

            double squareLength = square.Length();
            Console.WriteLine("\nSquare length: " + squareLength);

            double squareSurface = square.Surface();
            Console.WriteLine("Square surface: " + squareSurface);

            //Triangle parametrs

            Triangle triangle = new Triangle();

            triangle.Side_A = 5;
            triangle.Side_B = 4;
            triangle.Side_C = 3;

            double triangleLength = triangle.Length();
            Console.WriteLine("\nTriangle length: " + triangleLength);

            double triangleSurface = triangle.Surface();
            Console.WriteLine("Triangle surface: " + triangleSurface);
        }
    }
}