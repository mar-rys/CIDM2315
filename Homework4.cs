namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method()
            Q1_method();

            // Call Q2_method()
            Q2_method(5, "left");
            Q2_method(5, "right");
        }

        // Q1_method
        static void Q1_method()
        {
            int num1 = 10;
            int num2 = 15;
            int largest = GetLargestNumber(num1, num2);
            Console.WriteLine($"The largest number between {num1} and {num2} is: {largest}");
        }

        // Helper method for Q1:
        static int GetLargestNumber(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        // Q2_method
        static void Q2_method(int N, string shape)
        {
            Console.WriteLine($"N = {N}, Shape = {shape}");

            if (shape == "left")
            {
                // Left-sided triangle
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); // Move to the next line after each row
                }
            }
            else if (shape == "right")
            {
                // Right-sided triangle
                for (int i = 1; i <= N; i++)
                {
                    for (int j = N - i; j > 0; j--)
                    {
                        Console.Write(" "); // Print spaces before the stars
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(); // Move to the next line after each row
                }
            }
            else
            {
                Console.WriteLine("Invalid shape entered. Please enter 'left' or 'right'.");
            }
        }
    }
}