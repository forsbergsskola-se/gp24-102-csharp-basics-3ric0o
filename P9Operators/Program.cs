
Console.WriteLine("Give me a number of seconds");
    
int Userinput = int.Parse(Console.ReadLine());

int Days = Userinput / 86400;
    int RemainingSeconds = Userinput % 86400;

int Hours = RemainingSeconds / 3600;
    int Remainingseconds2 = RemainingSeconds % 3600;

int Minutes = Remainingseconds2 / 60;
    int Remainingseconds3 = Remainingseconds2 % 60;

int Seconds = Remainingseconds3;

double totalDays = Userinput / 86400;

Console.WriteLine("Seconds: " + Seconds);
Console.WriteLine("Minutes: " + Minutes);
Console.WriteLine("Hours: " + Hours);
Console.WriteLine("Days: " + Days);
Console.WriteLine(Days + "." + Hours + ":" + Minutes + ":" + Seconds);
Console.WriteLine("In total, that's " + totalDays);


