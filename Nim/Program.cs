Console.WriteLine("Welcome to Nim!");
Console.WriteLine("|||||||||||||||||||||||| (24)");

int userInput = 10;
int matchesNum = 24;
bool isPlayer = false;
Random seed = new Random();

while (matchesNum > 0)
{
    int Ai = seed.Next(1, 4);
    
    isPlayer = !isPlayer;

    if (isPlayer)
    {
        Console.WriteLine("\nHow many matches do you want to draw?");
        userInput = Int32.Parse(Console.ReadLine());

        while (userInput > 3)
        {
            Console.WriteLine("Please enter a number between 1 and 3");
            userInput = Int32.Parse(Console.ReadLine());
        }
    }
    else
    {
            Console.WriteLine("\nThe Ai Draws " + Ai + " matches.");
    }
    
    matchesNum -= isPlayer ? userInput : Ai;
    if (matchesNum >= 2)
    {
        for (int i = 0; i < matchesNum; i++)
        {
            Console.Write("|");
        }
        Console.Write(" " + matchesNum);
    }
    else if (matchesNum < 2)
    {
        Console.WriteLine(isPlayer ? "You Win!" : "You Lose!");
        break;
    }
}