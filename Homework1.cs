namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Linear line equation Z = 4X^2 + 3Y
            // Given values
            double X = 2.5;
            double Y = 3.3;

            // Calculate Z
            double Z = 4 * X * X + 3 * Y;

            // Print the result
            Console.WriteLine($"The value of Z when X = {X} and Y = {Y} is: {Z:F2}");
        }
    }
}
