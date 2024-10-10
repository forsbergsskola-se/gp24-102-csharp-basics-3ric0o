
Console.WriteLine("Give me a number."); 
string input = Console.ReadLine(); // User input
float number = float.Parse(input); // Convert the variable to float
Console.WriteLine(number);

int intNumber = Convert.ToInt32(number); // Convert the double number to int.
intNumber = (int) number;
Console.WriteLine(intNumber);

int intNumber2 = Convert.ToInt32(input); // Convert the original string to int



