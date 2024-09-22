Game:

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
        Console.WriteLine("\nHow many matches do you want to draw?\n");
        userInput = Int32.Parse(Console.ReadLine());

        while (userInput > 3)
        {
            Console.WriteLine("Please enter a number between 1 and 3");
            userInput = Int32.Parse(Console.ReadLine());
        }
    }
    else
    {
            Console.WriteLine("\n\nThe Ai Draws " + Ai + " matches. \n");
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
        Console.WriteLine(isPlayer ? "You Win!\n" : "You Lose!\n");
        break;
    }
}
Console.WriteLine("Thanks for Playing!\nDo you want to play again. (Y/N)");
    string again = Console.ReadLine();

    while (again != "Y" || again != "N")
    {
        {
            Console.WriteLine("Please answer 'Y' (Yes) or 'N' (No).");
            again = Console.ReadLine();
        }
        if (again == "N")
        {
            Console.WriteLine("\nOK... :C");
            break;
        }

        if (again == "Y")
        {
            goto Game;
        }
    }
        
    
    