class HumanPlayer
{
    private int points;
    
    public HumanPlayer(int initial)
    {
        points = initial;
    }
    
    public int GetPoints()
    {
        return points;
    }
    
    public void WinRound()
    {
        points += 5;
    }
    
    public void LoseRound()
    {
        points -= 5;
    }
    
    public string HumanDecision()
    {
        Console.Write("Please input your choice: rock, paper, or scissors: ");
        string input = Console.ReadLine() ?? string.Empty;
        return input?.ToLower() ?? string.Empty;
    }
}

class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, 3);
        
        if (rnd_num == 0) return "rock";
        else if (rnd_num == 1) return "paper";
        else return "scissors";
    }
}

class RockPaperScissors
{
    static void Main()
    {
        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer();

        while (human.GetPoints() > 0)
        {
            Console.WriteLine("\n**** Rock Paper Scissors, Start! ****");
            Console.WriteLine($"You have {human.GetPoints()} points");
            
            string humanChoice = human.HumanDecision();
            string computerChoice = computer.ComputerDecision();
            
            Console.WriteLine($"--> Your Decision: {humanChoice}");
            Console.WriteLine($"--> Computer Decision: {computerChoice}");
            
            if (humanChoice == computerChoice)
            {
                Console.WriteLine("It's a Tie!");
            }
            else if ((humanChoice == "rock" && computerChoice == "scissors") ||
                     (humanChoice == "scissors" && computerChoice == "paper") ||
                     (humanChoice == "paper" && computerChoice == "rock"))
            {
                Console.WriteLine("You win!");
                human.WinRound();
            }
            else
            {
                Console.WriteLine("You Lose!");
                human.LoseRound();
            }

            if (human.GetPoints() == 0)
            {
                Console.WriteLine("Sorry, you don't have enough points, thanks for playing.");
                Console.WriteLine("Thank you for playing!");
                break;
            }
            
            Console.Write("--> Play again? Input y to continue, or n to exit: ");
            if ((Console.ReadLine() ?? string.Empty).ToLower() != "y")
            {
                Console.WriteLine("Thank you for playing!");
                break;
            }
        }
    }
}
