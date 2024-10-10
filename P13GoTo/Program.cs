Random myNumber = new Random();
    int number = myNumber.Next(0, 101);

Console.WriteLine("I have picked a number (1-100) It's your turn to guess it!");
    int userGuess = -1;

    int MaxGuess = 10;
    int CurrentGuess = 0;
    int TryCounter = 0;

while (userGuess != number && CurrentGuess < MaxGuess) 
{
    Console.Write("Enter your guess: ");
    userGuess = int.Parse(Console.ReadLine());
    if (number < userGuess)
    {
        Console.WriteLine("My number is Smaller");
    }
    else if (number > userGuess)
    {
        Console.WriteLine("My number is Larger");
    }
    else // This handles the case where myNumber == userGuess
    {
        Console.WriteLine("That's the number! Well played!");
    }
    TryCounter++;
    if (userGuess == number)
        Console.WriteLine("You needed " + TryCounter + " guesses to Win!" );
    
    CurrentGuess++;
    if (CurrentGuess == MaxGuess)
    {
        Console.WriteLine("You've guessed 10 times, You Lose");
    }
}







    