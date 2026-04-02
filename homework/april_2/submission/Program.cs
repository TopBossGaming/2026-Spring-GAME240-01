// This is the calculator assignment but again for April 2

int number1;
int number2;

number1 = 0;
number2 = 0;



Console.WriteLine("What equation would you like me to solve?");
Console.WriteLine("(Write it as x / y and replace the symbol with whatever you want)");

string initialQ;
initialQ = Console.ReadLine();

string[] splitQ;
splitQ = initialQ.Split();

// We can put the numbers and symbol into seperate variables so we don't have to recall the string
number1 = int.Parse(splitQ[0]);
number2 = int.Parse(splitQ[2]);

string equation;
equation = splitQ[1];

int answer;
answer = 0;

//We need the division answer to be a double because an int doesn't support the possibility of decimals.
double divAnswer;
divAnswer = 0;

//The meat
if (equation == "+")
{
    answer = number1 + number2;
    //Teachers hate this one slick trick
    Console.WriteLine($"{number1}{equation}{number2} is equal to {answer}");
}
else if (equation == "-")
{
    answer = number1 - number2;
    Console.WriteLine($"{number1}{equation}{number2} is equal to {answer}");
}
else if (equation == "*")
{
    answer = number1 * number2;
    Console.WriteLine($"{number1}{equation}{number2} is equal to {answer}");
}
else if (equation == "/")
{
    divAnswer = (double)number1 / number2;
    //Need to remember to replace the anwer with the division version
    Console.WriteLine($"{number1}{equation}{number2} is equal to {divAnswer}");
}
    
else if (equation == "%")
{
    answer = number1 % number2;
    Console.WriteLine($"{number1}{equation}{number2} is equal to {answer}");
}
else
{
    Console.WriteLine("Please provide a proper expression");
}

//Originally tried to put it at the end but couldn't account for an improper value.
