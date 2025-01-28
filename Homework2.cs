namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1
            Console.WriteLine("Enter your grade (A, B, C, D, F): ");
            string grade = (Console.ReadLine() ?? string.Empty).ToUpper(); // Provide default value if null

            if (grade == "A")
            {
                Console.WriteLine("Your GPA is: 4");
            }
            else if (grade == "B")
            {
                Console.WriteLine("Your GPA is: 3");
            }
            else if (grade == "C")
            {
                Console.WriteLine("Your GPA is: 2");
            }
            else if (grade == "D")
            {
                Console.WriteLine("Your GPA is: 1");
            }
            else if (grade == "F")
            {
                Console.WriteLine("Your GPA is: 0");
            }
            else
            {
                Console.WriteLine("Wrong Letter Grade!");
            }
            // Code for Q2
            Console.WriteLine("\nEnter three numbers to find the smallest:");

            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter number 3: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            int smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine($"The smallest number is: {smallest}");

            // Code for Bonus question
            Console.WriteLine("\nEnter a year to check if it's a leap year:");
            int year = Convert.ToInt16(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}
