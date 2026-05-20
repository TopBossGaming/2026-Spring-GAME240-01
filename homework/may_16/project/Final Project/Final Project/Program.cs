//Here it is, the game

string moveInDirection(string direction, string current_room, bool exitOpen=false)
{
    string roomToGoTo = current_room;
    
    if ((direction == "north") || (direction == "up"))
    {
        if (current_room == "Bunks")
        {
            roomToGoTo = "Hallway";
        }
        else if (current_room == "Hallway")
        {
            Console.WriteLine("You run into rubble");
        }
        else if (current_room == "LeisureRoom")
        {
            roomToGoTo = "LockerRoom";
        }
        else if (current_room == "DiningRoom")
        {
            roomToGoTo = "Captain'sRoom";
        }
        else
        {
            Console.WriteLine("You run into a wall");
        }

    }
    else if ((direction == "south") || (direction == "down"))
    {
        if (current_room == "Hallway")
        {
            roomToGoTo = "Bunks";
        }
        else if (current_room == "LockerRoom")
        {
            roomToGoTo = "LeisureRoom";
        }
        else if (current_room == "Captain'sRoom")
        {
            roomToGoTo = "DiningRoom";
            
        }
        else
        {
            Console.WriteLine("You run into a wall");
        }
            
    }
    else if ((direction == "east") || (direction == "right"))
    {
        if (current_room == "Hallway")
        {
            roomToGoTo = "Kitchen";
        }
        else if (current_room == "LeisureRoom")
        {
            roomToGoTo = "Hallway";
        }
        else if (current_room == "LockerRoom")
        {
            roomToGoTo = "DiningRoom";
        }
        else if (current_room == "DiningRoom")
        {
            printSlowly("You run into a wall");
            printSlowly("The door is locked and sturdy");
            printSlowly("But has your face outlined with dust");
            printSlowly("You shake yourself off");
        }
        else
        {
            Console.WriteLine("You run into a wall");
        }
            
    }
    else if ((direction == "west") || (direction == "left"))
    {
        if (current_room == "Hallway")
        {
            roomToGoTo = "LeisureRoom";
        }
        else if (current_room == "Kitchen")
        {
            roomToGoTo = "Hallway";
        }

        if (current_room == "DiningRoom")
        {
            roomToGoTo = "LockerRoom";
        }
        else
        {
            Console.WriteLine("You run into a wall");
        }
            
    }
    else
    {
        Console.WriteLine("I don't know how to move in that direction");
    }

    return roomToGoTo;
    
}


void printSlowly(string sentence, int textSpeed=50)
{
    int currentLetter = 0;
    while (currentLetter < sentence.Length)
    {
        Console.Write(sentence[currentLetter]);
        Thread.Sleep(millisecondsTimeout:textSpeed);
        currentLetter++;
    }
    Console.Write("\n");
}


string command;
string input;
string additionalInfo;
bool end;
end = false;

string currentRoom = "Bunks";

string[] inventory = ["", "", "", ""];

bool beenToHallway = false;
bool beenToLesiure = false;
bool beenToKitchen = false;
bool beenToLockers = false;
bool beenToDining = false;
bool beenToCaptain = false;
bool letterTaken = false;

bool usedLetter = false;
bool usedHook = false;

printSlowly("You awake in a room with scratched gray walls made of metal");
printSlowly(
    "There are bunk beds lined against the walls, no sheets or pillows, just a mattress bellow another mattress");
printSlowly("There is a door in front of you, with the number nine painted with red on it");
printSlowly("Bellow is a keyboard with instructions beside it");


while (end == false)
{
    Console.WriteLine("Enter 3 unique numbers that add up to 9, each separated by a space");
    
    input = Console.ReadLine();
    try
    {
        string[] ans = input.Split(' ');
        int total = 0;
        total += int.Parse(ans[0]) + int.Parse(ans[1]) + int.Parse(ans[2]);
        if (total == 9)
        {
            if ((int.Parse(ans[0]) != int.Parse(ans[1])) && (int.Parse(ans[0]) != int.Parse(ans[2])) && (int.Parse(ans[1]) != int.Parse(ans[2])))
            {
                if (ans.Length == 3)
                {
                    end = true;
                }
            }
        }
        

    }
    catch (Exception e)
    {
        
    }
}

printSlowly("The door slides open, revealing a path forward");
end = false;


while (end == false)
{
    Console.WriteLine("what would you like to do?");
    input = Console.ReadLine();
    input = input.ToLower();

    string[] splitInput;
    splitInput = input.Split(" ");

    command = splitInput[0];
    try
    {
        additionalInfo = splitInput[1];
        if (command == "move")
        {
            //TO DO: handle movement in a direction
            currentRoom = moveInDirection(additionalInfo, currentRoom);

        }
        else if (command == "take")
        {
            if ((currentRoom == "Kitchen") && (additionalInfo == "torch") && ("light" != inventory[0]))
            {
                printSlowly("You grab the torch, it still has batteries and shines quite brightly, it must be useful");
                inventory[0] = "light";
            }
            else if ((currentRoom == "LeisureRoom") && ((additionalInfo == "deep") || (additionalInfo == "deepregrets")) && ("hook" != inventory[1]))
            {
                printSlowly("You grab the box, and you were right to do so, its weight is much lighter compared");
                printSlowly("To the others, you open it revealing the end of fishing rod, you take it");
                printSlowly("You set the game back down");
                inventory[1] = "hook";
            }
            else if ((currentRoom == "LeisureRoom") && ((additionalInfo == "deep") || (additionalInfo == "deepregrets")) && ("hook" == inventory[1]))
            {
                printSlowly("You open the box back up and the only thing that remains is the rules");
                
            }
            else if ((letterTaken == false) && (currentRoom == "LockerRoom") && ((additionalInfo == "letter") ||
                                                       (additionalInfo == "loveletter") || (additionalInfo == "love")))
            {
                printSlowly("You grab the letter once more despite your own apprehension");
                printSlowly("You turn it inside and out and there is nothing of notice");
                printSlowly("You fold the letter into a paper heart");
                printSlowly("It looks quite pretty");
                printSlowly("You take the letter with you, hopefully you can deliver it");
                inventory[2] = "letter";
                letterTaken = true;
            }
            else
            {
                Console.WriteLine("You take the air and stuff it into your pocket");
                Console.WriteLine("You can't take " + additionalInfo);
            }
        }
        else if (command == "use")
        {
            if ((currentRoom == "Captain'sRoom") && (additionalInfo == "letter") && ("letter" == inventory[2]))
            {
                printSlowly("You place the love letter into the lap of the captain, it smiles, revealing a key in its mouth");
                printSlowly("You reach out to grab it, but the mouth is too small to fit your fingers");
                printSlowly("You go to shake the skeleton but you stop yourself, that would be disgusting");
                usedLetter = true;
                inventory[2] = "";
            }
            else if ((currentRoom == "Captain'sRoom") && (additionalInfo == "hook") && ("hook" == inventory[1]) && (usedLetter == true))
            {
                printSlowly("You take the hook and carefully insert into the mouth of the skeleton");
                printSlowly("POOCK! you hit the mouth");
                printSlowly("PLING! you hit a tooth");
                printSlowly("BLOCK! you hit another tooth");
                printSlowly("and . . . .", 100);
                printSlowly("You hit the eye", 25);
                printSlowly("Your really bad at this", 10);
                printSlowly("You eventually insert it into the mouth properly and pull out the key");
                inventory[2] = "Key";
            }
            else if ((currentRoom == "DiningRoom") && (additionalInfo == "key") && ("Key" == inventory[2]))
            {
                end = true;
            }
            else
            {
                Console.WriteLine("You use your brain and come up with nothing worth while");
                Console.WriteLine("You can't use " + additionalInfo + " here");
            }
        }
        else
        {
            Console.WriteLine("I don't understand.");
        }
    }
    catch (Exception e)
    {
        command = input;
    
        if (command == "move")
        {
            Console.WriteLine("What direction?");
            string var = Console.ReadLine().ToLower();
            currentRoom = moveInDirection(var, currentRoom);
        }
        else if (command == "take")
        {
            Console.WriteLine("You try to grab the air, but it doesn't agree (include what your taking with your statement)");
        }
        else if (command == "use")
        {
            Console.WriteLine("You enter your fingers into the invisible door and turn... revealing nothing (include what your using with your statement)");
        }
        else
        {
            Console.WriteLine("I don't understand.");
        }   
    }

    if (currentRoom == "Hallway")
    {
        if (beenToHallway == false)
        {
            printSlowly("You enter a stretched cross shape room, with rubble ahead");
            printSlowly("There is a white path to your right");
            printSlowly("But besides from this, you can't see much");
            beenToHallway = true;
        }
        else
        {
            Console.WriteLine("A cross shape room, with rubble ahead");
            Console.WriteLine("There is a white path to your right");
            if ("light" == inventory[0])
            {
                {
                    printSlowly("There is a dark door with a circular window to your left", 10);
                }
                
                
                
            }
        }

    }
    else if (currentRoom == "Kitchen")
    {
        if (beenToKitchen == false)
        {
            printSlowly("Pots and pans and other dishes are in the room, none having any edible speck of food");
            printSlowly("Mold and dust fill the room, its quite disgusting and takes a bit out of you to make sure you don't throw up, or cough");
            printSlowly("Attached to the walls are even more tools of the trade, a large steak knife, spoons, a torch, and forks");
            beenToKitchen = true;
        }
        else
        {
            Console.WriteLine("Pots and pans and other dishes are in the room, none having any edible speck of food");
            Console.WriteLine("Mold and dust fill the room, its quite disgusting and takes a bit out of you to make sure you don't throw up");
            if ("light" == inventory[0])
            {
                Console.WriteLine("Attached to the walls are even more tools of the trade, a large steak knife, spoons, and forks");
            }
            else
            {
                Console.WriteLine("Attached to the walls are even more tools of the trade, a large steak knife, spoons, a torch, and forks");
            }
            
        }

    }
    else if (currentRoom == "LeisureRoom")
    {
        if (beenToLesiure == false)
        {
            printSlowly("Its a room with its lights off, you flick a switch and you see a room filled with activities");
            printSlowly("Theres a couch for sleeping, a pool table for pooling, and bookshelves filled with books");
            printSlowly("There is also a table or two filled with the type of mass produced board games you would expect");
            printSlowly("Monopoly, Sorry, Yahtzee, DeepRegrets, Scrabble, CandyLand, and Jenga");
            printSlowly("And theres another door ahead of you");
            beenToLesiure = true;
        }
        else
        {
            Console.WriteLine("Theres a couch for sleeping, a pool table for pooling, and bookshelves filled with books");
            Console.WriteLine("Monopoly, Sorry, Yahtzee, DeepRegrets, Scrabble, CandyLand, and Jenga sit on a table");
            Console.WriteLine("And theres another door ahead of you");
        }
    }
    else if (currentRoom == "LockerRoom")
    {
        if (beenToLockers == false)
        {
            printSlowly("Many lockers fill the room, each more empty than the last, except for one");
            printSlowly("It contains a note, a love letter expressing the love for-");
            printSlowly("You stop reading, its not interesting");
            printSlowly("There is a door to your right");
            beenToLockers = true;
        }
        else
        {
            Console.WriteLine("Many lockers line the room, one of them had a letter");
            Console.WriteLine("There is a door behind you and to your right");
        }
    }
    else if (currentRoom == "DiningRoom")
    {
        if (beenToDining == false)
        {
            printSlowly("The room is beautiful, is what you would of said 50 years ago");
            printSlowly("Its one long table, filled with the seats of the dead");
            printSlowly("There are no plates, no silverware, nothing");
            printSlowly("Except for cobwebs");
            printSlowly("There is a door to your right and up");
            beenToDining = true;
        }
        else
        {
            Console.WriteLine("Its one long table, filled with the seats of the dead");
            Console.WriteLine("There is a door to your left, right and up");
        }
    }
    else if (currentRoom == "Captain'sRoom")
    {
        if (beenToCaptain == false)
        {
            printSlowly("It seems to be a fresher room... well it would of if there wasn't a skeleton");
            printSlowly("It sits on the Captain's chair, and its lap is grasping for something");
            printSlowly("The rest of the room is what you would expect from a Captains room, except you can't see through the windows");
            beenToCaptain = true;
        }
        else
        {
            if (usedLetter == true)
            {
                printSlowly("The Captain's mouth is still open", 15);
            }
            else
            {
                printSlowly("The lap of the Captain begs you for something", 10);
            }
        }
    }




    Console.WriteLine("You are in the " + currentRoom);
    
}


printSlowly("You open the Dining Room door, and it reveals a set of stairs");
printSlowly("Exhausted, but still wishing to escape, you climb the stairs one by one");
printSlowly("It feels like you have climbed for hours, but eventually you see a light above a door");
printSlowly("You slowly open the door revealing a harsh sun that forces you to shut your eyes for a bit");
printSlowly("You open them to a desert, filled with sand");
printSlowly("And behind you, there is a ship, half buried into the sand");

printSlowly("Where are you?", 100);

Console.WriteLine("THE END");

