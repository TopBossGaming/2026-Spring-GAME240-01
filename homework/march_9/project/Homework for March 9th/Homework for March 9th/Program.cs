//using a while loop, find the biggest and smallest numbers in the array.

using System.Globalization;
using System.Runtime.InteropServices;

int[] array = [43, -5, 95, 612, 0];

int i;
i = 0;
int biggestNum;
int smallestNum;

biggestNum = array[i];
smallestNum = array[i];

while (i < array.Length)
{
    int currentNumber = array[i];

    if (currentNumber > biggestNum)
    {
        biggestNum = currentNumber;
    }
    if (currentNumber < smallestNum)
    {
        smallestNum = currentNumber;
    }
    i = i + 1;
    
}

Console.WriteLine("Your smallest number is " + smallestNum);
Console.WriteLine("Your biggest number is " + biggestNum);
