
Console.WriteLine("What's your age?");
int age = Int32.Parse( Console.ReadLine());

bool isChild = age <= 12;
    if (isChild) Console.WriteLine("You're a child");

bool isTeenager = age >= 13 && age <= 19;
    if (isTeenager) Console.WriteLine("You're a teenager");

bool isAdult = age > 19;
    if (isAdult) Console.WriteLine("You're an adult");

Console.WriteLine("Give me another integer.");
    int UserInput = Int32.Parse(Console.ReadLine());
    
int result = (UserInput > age) ? (UserInput) : (age);
    Console.WriteLine("The maximum is: " + result);

    if (UserInput % 2 == 0)
    {
        Console.WriteLine("That number is an even number");
    }
    else
    {
        Console.WriteLine("That number is an odd number");
    }



    
    