namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        int largestOfTwo = Q1_method();
        Console.WriteLine($"The largest of the two numbers is: {largestOfTwo}");

        // Call Q2_method()
        int largestOfFour = Q2_method();
        Console.WriteLine($"The largest of the four numbers is: {largestOfFour}");

        // Call Q3_method()
        Q3_method();
    }

    // Q1_method
    static int Q1_method()
    {
        Console.Write("Enter the first integer: ");
        string inputA = Console.ReadLine() ?? string.Empty;
        int a = string.IsNullOrEmpty(inputA) ? 0 : int.Parse(inputA);

        Console.Write("Enter the second integer: ");
        string inputB = Console.ReadLine() ?? string.Empty;
        int b = string.IsNullOrEmpty(inputB) ? 0 : int.Parse(inputB);

        return Math.Max(a, b);
    }

    // Q2_method
    static int Q2_method()
    {
        Console.Write("Enter the first integer: ");
        string inputA = Console.ReadLine() ?? string.Empty;
        int a = string.IsNullOrEmpty(inputA) ? 0 : int.Parse(inputA);

        Console.Write("Enter the second integer: ");
        string inputB = Console.ReadLine() ?? string.Empty;
        int b = string.IsNullOrEmpty(inputB) ? 0 : int.Parse(inputB);

        Console.Write("Enter the third integer: ");
        string inputC = Console.ReadLine() ?? string.Empty;
        int c = string.IsNullOrEmpty(inputC) ? 0 : int.Parse(inputC);

        Console.Write("Enter the fourth integer: ");
        string inputD = Console.ReadLine() ?? string.Empty;
        int d = string.IsNullOrEmpty(inputD) ? 0 : int.Parse(inputD);

        int max1 = Q1_method_internal(a, b); // Using a helper for internal calls
        int max2 = Q1_method_internal(c, d); // Using a helper for internal calls
        return Math.Max(max1, max2);
    }

    // Helper method to avoid redundant console input prompts
    static int Q1_method_internal(int a, int b)
    {
        return Math.Max(a, b);
    }

    // Q3_method
    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void Q3_method()
    {
        Console.Write("Enter username: ");
        _ = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine() ?? string.Empty;

        Console.Write("Enter birth year: ");
        string inputBirthYear = Console.ReadLine() ?? string.Empty;
        int birthYear = string.IsNullOrEmpty(inputBirthYear) ? 0 : int.Parse(inputBirthYear);

        Console.Write("Confirm password: ");
        string confirmPassword = Console.ReadLine() ?? string.Empty;

        if (checkAge(birthYear))
        {
            if (password == confirmPassword)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}