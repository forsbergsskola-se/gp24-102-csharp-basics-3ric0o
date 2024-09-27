
Console.WriteLine("Give me a number of seconds");
    
int Userinput = int.Parse(Console.ReadLine());

int Days = Userinput / 86400;
    int RemainingSeconds = Userinput % 86400;

int Hours = RemainingSeconds / 3600;
    int Remainingseconds2 = RemainingSeconds % 3600;

int Minutes = Remainingseconds2 / 60;
    int Remainingseconds3 = Remainingseconds2 % 60;

int Seconds = Remainingseconds3;

double totalDays = (double)Userinput / 86400;

Console.WriteLine("Seconds: " + Seconds);
Console.WriteLine("Minutes: " + Minutes);
Console.WriteLine("Hours: " + Hours);
Console.WriteLine("Days: " + Days);
Console.WriteLine(Days + "." + Hours + ":" + Minutes + ":" + Seconds);
Console.WriteLine("In total, that's " + totalDays);

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

// P09_01

Console.WriteLine("Type a number that will represent the speed in Km/h");
    float Speed = float.Parse(Console.ReadLine());
    Speed = Speed * 1000;
    Speed = Speed / 3600;
Console.WriteLine("It's " + Speed + " m/s");

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_02

Console.WriteLine("Type a number that will represent a number of Minutes");
    float minutes = float.Parse(Console.ReadLine());
    float seconds = minutes * 60;
Console.WriteLine("It's " + seconds + " seconds");

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_03

Console.WriteLine("Input 2 integers");
    string[] inputsplit = Console.ReadLine().Split(',');

    float numb1 = float.Parse(inputsplit[0]);
    float numb2 = float.Parse(inputsplit[1]);

    float divide = numb1 / numb2;
    
Console.WriteLine("Number 1 divided by Number 2= " + divide);

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_04
Console.WriteLine("Input 2 different integers");
    string input = Console.ReadLine();
    string[] split = input.Split(',');

    int num1 = int.Parse(split[0]);
    int num2 = int.Parse(split[1]);

int remainder = num1 % num2;
Console.WriteLine("Remainder: " + remainder);

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_06

Console.WriteLine("Put it a integer");
    int num3 = int.Parse(Console.ReadLine());
    int negatednum = -num3;

Console.WriteLine("Negated number: " + negatednum);

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_07

Console.WriteLine("Input 2 different integers");
string input2 = Console.ReadLine();
string[] split2 = input2.Split(',');

int number1 = int.Parse(split2[0]);
int number2 = int.Parse(split2[1]);

int multiplication = number1 * number2;
Console.WriteLine("Multiplication result: " + multiplication);

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_08

Console.WriteLine("Enter your weight in kilograms: ");
    float kg = float.Parse(Console.ReadLine());
Console.WriteLine("Enter your height in meters: ");
    float height = float.Parse(Console.ReadLine());

    float bmi = kg / (height * height);

Console.WriteLine("BMI: " + bmi);

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_09

Console.WriteLine("Input 2 different numbers for the triangle");
    string[] split3 = Console.ReadLine().Split(',');

    float length1 = float.Parse(split3[0]);
    float length2 = float.Parse(split3[1]);

    float hypotenuse = (length1 * length1) + (length2 * length2);
    double result = Math.Sqrt(hypotenuse);

Console.WriteLine("The length of the hypotenuse of a right triangle is: " + result);

Console.WriteLine("Press any key to go next.");
Console.ReadLine();
Console.Clear();

//P09_10

Console.WriteLine("Input a number that will represend the number of seconds");
    int seconds1 = int.Parse(Console.ReadLine());

int minutes1 = seconds1 / 60;
seconds1 = seconds1 % 60;

Console.WriteLine("Minute(s): " + minutes1 + " and " + seconds1 + " Second(s)");








    
    
   






