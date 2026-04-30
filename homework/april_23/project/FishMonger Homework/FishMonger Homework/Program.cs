



string firstLine;
bool isFilePathValid = false;
string logPath;
string specialPath;
string outPutPath;

logPath = "";
specialPath = "";
outPutPath = "";

while (isFilePathValid == false)
{
    Console.WriteLine("Where is the log?");
    logPath = Console.ReadLine();
    
    try
    {
        StreamReader reader = new StreamReader(logPath);
        
        isFilePathValid = true;
        
        reader.Close();
        
    }
    catch (Exception e)
    {
        Console.WriteLine("Failed to find file");
    }
}

isFilePathValid = false;

while (isFilePathValid == false)
{
    Console.WriteLine("Where is the special?");
    specialPath = Console.ReadLine();
    
    try
    {
        StreamReader reader = new StreamReader(specialPath);
        
        isFilePathValid = true;
        
        reader.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Failed to find file");
    }
}

isFilePathValid = false;

while (isFilePathValid == false)
{
    Console.WriteLine("Where should we write the output?");
    outPutPath = Console.ReadLine();
    
    try
    {
        StreamWriter writer = new StreamWriter(outPutPath);
        isFilePathValid = true;
        writer.Close();
        
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
        throw;
    }
}

string special;
string line;
int totalFish;
int specialCaught;

totalFish = 0;
specialCaught = 0;
special = "";
line = "";


StreamReader Fspecial = new StreamReader(specialPath);

line = Fspecial.ReadLine();

string[] specialList = line.Split(' ');

special = specialList[3];

Fspecial.Close();

StreamReader log = new StreamReader(logPath);

line = log.ReadLine();

while (line != null)
{
    
    string[] lineArray =  line.Split(' ');

    int numCaught = int.Parse(lineArray[0]);
    totalFish += numCaught;
    if ((lineArray[1]) == special)
    {
        specialCaught += numCaught;
    }
    line = log.ReadLine();
}

log.Close();


StreamWriter outFile =  new StreamWriter(outPutPath);

outFile.WriteLine($"Today's special is: {special}");
outFile.WriteLine($"Total {special} caught: {specialCaught}");
outFile.WriteLine($"All fish caught: {totalFish}");

outFile.Close();
