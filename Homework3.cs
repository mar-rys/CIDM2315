namespace Homework3;
class Program
{
    static void Main(string[]args)
    {
        // Code for Q1
        Console.Write("Enter a number: ");
        int? nullableN = int.TryParse(Console.ReadLine(), out int tempN) ? tempN : null;
        int N = nullableN ?? throw new ArgumentNullException(nameof(nullableN));
       
        bool isPrime = true;
        if (N < 2)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine(isPrime ? "N is prime" : "N is non-prime");


        // Code for Q2
        Console.Write("Enter a number for square pattern: ");
        int? nullableSize = int.TryParse(Console.ReadLine(), out int tempSize) ? tempSize : null;
        int size = nullableSize ?? throw new ArgumentNullException(nameof(nullableSize));
       
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


        // Code for Q3
        Console.Write("Enter a number for border pattern: ");
        int? nullableBorderSize = int.TryParse(Console.ReadLine(), out int tempBorderSize) ? tempBorderSize : null;
        int borderSize = nullableBorderSize ?? throw new ArgumentNullException(nameof(nullableBorderSize));
       
        for (int i = 0; i < borderSize; i++)
        {
            for (int j = 0; j < borderSize; j++)
            {
                if (i == 0 || i == borderSize - 1 || j == 0 || j == borderSize - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }


        // Code for Bonus Question
        Console.Write("Enter a number for X pattern: ");
        int? nullableXSize = int.TryParse(Console.ReadLine(), out int tempXSize) ? tempXSize : null;
        int xSize = nullableXSize ?? throw new ArgumentNullException(nameof(nullableXSize));
       
        for (int i = 0; i < xSize; i++)
        {
            for (int j = 0; j < xSize; j++)
            {
                if (i == j || j == xSize - i - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
