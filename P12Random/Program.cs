
Console.WriteLine("Please pass me a seed (integer).");
    int UserInput = Int32.Parse(Console.ReadLine());

    Random random = new Random(UserInput);

Console.WriteLine("Three numbers between 0 and 5");   

for (int i = 0; i < 3; i++)
{
    int number = random.Next(0, 5);
        Console.WriteLine(number);
}      
    
Console.WriteLine("Three numbers between 0 and 0.5");    

for (int i = 0; i < 3; i++)
{
        double number = random.NextDouble() * 0.5;
        Console.WriteLine(number);
}

Console.WriteLine("Three numbers between 0.2 and 0.8");    

for (int i = 0; i < 3; i++)
{
    double number = random.NextDouble() *(0.7-0.2)+0.2;
    Console.WriteLine(number);
}

Console.WriteLine("Give me a crit chance between 0.0 (o%) and 1.0 (100%)"); 
    double CritInput = Double.Parse(Console.ReadLine());
   
for (int i = 0; i < 5; i++)
{
    Double Crit = random.NextDouble() * 1.0;
    if (CritInput >= Crit)
    {
        Console.WriteLine("Crit");
    }
    else
    {
        Console.WriteLine("No Crit");
    }
}
