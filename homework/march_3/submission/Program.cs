
int count;

count = 0;

while (count < 5)
{
    count = count + 1;
    Console.WriteLine(count);
}

count = 100;

while (count <= 150)
{
    Console.WriteLine(count);
    count = count + 1;
}

count = 0;

while (count <= 100)
{
    Console.WriteLine(count);
    count = count + 2;
}

count = 20;

while (count >= -20)
{
    Console.WriteLine(count);
    count = count - 1;
}

count = 1;

while (count <= 100)
{
    Console.WriteLine(count);
    count = count + 3;
}

count = 1;

while (count <= 1024)
{
    Console.WriteLine(count);
    count = count * 2;
}

string response;
response = "";

do
{
    
    Console.WriteLine("Do you want the loop to stop?");
    response = Console.ReadLine();

} while (response != "yes");

bool alternate;
alternate = true;

count = 0;

while (count < 20)
{
    Console.WriteLine(alternate);
    if (alternate == true)
    {
        alternate = false;
    }
    else
    {
        alternate = true;
    }

    count = count + 1;
}

count = 1;

bool even;
even = false;

string countString;
countString = "";

while (count <= 20)
{
    if (even == true)
    {
        countString = count.ToString();
        Console.WriteLine(countString + " is even");
        even = false;
    }
    else
    {
        countString = count.ToString();
        Console.WriteLine(countString + " is odd");
        even = true;
    }
    count = count + 1;
}