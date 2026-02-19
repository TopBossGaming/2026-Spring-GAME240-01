// This is my calculator

using System.Runtime.InteropServices;

// Create the variables that will be used throughout the program

float numberOne;
float numberTwo;
string value1;
string value2;

float answer = 0;

// Asking the user for what they want to do as well as including what they need to type in
Console.WriteLine("What calculation would you like me to do? (add/sub/div/mult)");

string mathEquation;

mathEquation = "Nothing";

mathEquation = Console.ReadLine();

// List of everything that needs to be done

if (mathEquation == "add")
{
    Console.WriteLine("What number shall be the base?");
    value1 = Console.ReadLine();
    
    Console.WriteLine("What number shall be added?");
    value2 = Console.ReadLine();
    
    numberOne = float.Parse(value1);
    numberTwo = float.Parse(value2);
    
    answer = numberOne + numberTwo;
    
    Console.WriteLine("Your answer is " + answer);
}
else if (mathEquation == "sub")
{
    Console.WriteLine("What number shall be the base?");
    value1 = Console.ReadLine();
    
    Console.WriteLine("What number shall be subtracted?");
    value2 = Console.ReadLine();
    
    numberOne = float.Parse(value1);
    numberTwo = float.Parse(value2);
    
    answer = numberOne - numberTwo;
    
    Console.WriteLine("Your answer is " + answer);
}
else if (mathEquation == "div")
{
    Console.WriteLine("What number shall be the base?");
    value1 = Console.ReadLine();
    
    Console.WriteLine("What number shall it be divided by?");
    value2 = Console.ReadLine();
    
    numberOne = float.Parse(value1);
    numberTwo = float.Parse(value2);
    
    answer = numberOne / numberTwo;
    
    Console.WriteLine("Your answer is " + answer);
}
else if (mathEquation == "multi")
{
    Console.WriteLine("What number shall be the base?");
    value1 = Console.ReadLine();
    
    Console.WriteLine("What number shall it be multiplied by?");
    value2 = Console.ReadLine();
    
    numberOne = float.Parse(value1);
    numberTwo = float.Parse(value2);
    
    answer = numberOne * numberTwo;
    
    Console.WriteLine("Your answer is " + answer);
}
else
{
    Console.WriteLine("Please enter a valid responses which includes: add, sub, div, multi");
}