// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rock, Paper, Scissors");

string inputPlayer, inputCPU;
int randopmInt;
    
bool playAgain = true;

while (playAgain)
{
    int scorePlayer = 0,
    scoreCPU = 0;

    while (scorePlayer < 3 && scoreCPU < 3)
    {
        Console.Write("Choose between ROCK, PAPER and SCISSORS: ");
        inputPlayer = Console.ReadLine().ToUpper();

        Random rand = new Random();
        randopmInt = rand.Next(1, 4);

        switch (randopmInt)
        {
            case 1:
                inputCPU = "ROCK";
                Console.WriteLine("Computer chose ROCK");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("DRAW...\n\n");
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("PLAYER WINS !\n\n");
                    scorePlayer++;
                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("CPU WINS !\n\n");
                    scoreCPU++;
                }
                break;
            case 2:
                inputCPU = "PAPER";
                Console.WriteLine("Computer chose PAPER");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("PLAYER WINS !\n\n");
                    scoreCPU++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("DRAW...\n\n");
                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("PLAYER WINS !\n\n");
                    scorePlayer++;
                }
                break;
            case 3:
                inputCPU = "SCISSORS";
                Console.WriteLine("Computer chose SCISSORS");
                if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("PLAYER WINS !\n\n");
                    scorePlayer++;
                }
                else if (inputPlayer == "PAPER")
                {
                    Console.WriteLine("CPU WINS !\n\n");
                    scoreCPU++;
                }
                else if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("DRAW...\n\n");
                }
                break;
            default:
                Console.WriteLine("Invalid entry!");
                break;
        }

        Console.WriteLine($"Player < {scorePlayer} | {scoreCPU} > CPU");

        if (scorePlayer == 3)
        {
            Console.WriteLine("Player wins!");
        }
        else if (scoreCPU == 3)
        {
            Console.WriteLine("CPU wins!");
        }
        
    }
    Console.WriteLine("Do yo uwant to play again ? (y/n)");
    string loop = Console.ReadLine();
    if (loop == "y")
    {
        playAgain = true;
        Console.Clear();
    }
    else if (loop == "n")
    {
        playAgain = false;
    }
    else
    {
        Console.WriteLine("Invalid entry!");
    }
}

