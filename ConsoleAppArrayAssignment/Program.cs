using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] arg)
    {
        //ARRAY OF STRINGS
        
        //declaring the ARRAY of STRINGS with size.
        string[] strArray = new string[8];

        //creating an instance of the string Array.
        strArray[0] = "Greetings to You!";
        strArray[1] = "What's your name?";
        strArray[2] = "I see you are from the other side.";
        strArray[3] = "What's it like being on the other side?";
        strArray[4] = "What's your staple food on the other side?";
        strArray[5] = "What brings you to our side?";
        strArray[6] = "If only I could remember my name!";
        strArray[7] = "What's the population there?";

        tryAgain: //brings back program control after invalid input.

        //Collecting user input of Array index selection.
        Console.WriteLine("Enter your STRING ARRAY index selection (0 - 7): ");
        int keySelection = Convert.ToInt32(Console.ReadLine());

        switch (keySelection)
        {
            case 0:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            case 1:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            case 2:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            case 3:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            case 4:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            case 5:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            case 6:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            case 7:
                Console.WriteLine("You selected the index: " + keySelection);
                Console.WriteLine();
                Console.WriteLine("Your selected string is: ");
                Console.WriteLine(strArray[keySelection]);
                Console.WriteLine();
                break; //jumping out of the switch.

            default:
                Console.WriteLine("Your selection is not valid. Please try again!");
                goto tryAgain;  //returning program control to the start.              
        }

        //ARRAY OF INTEGERS

        //declaring and initialising the ARRAY of INTEGERS in a single line.

        int[] numArray = { 43, 77, 783, 3671, 11, 3333, 7, 21 };        
        
        tryAgain1:

        //collecting user keyboard input of Array index selection.
        Console.WriteLine("Enter your INTEGER ARRAY index selection (0 - 7): ");
        int arrayIndex = Convert.ToInt32(Console.ReadLine());

        try
        {
            int indexTest1 = numArray[arrayIndex];
            Console.WriteLine("You selected the index: " + arrayIndex);
            Console.WriteLine();
            Console.WriteLine("Your integer selection is: ");
            Console.WriteLine(indexTest1);
            Console.WriteLine();                        
        }
        
        catch
        {
            Console.WriteLine("Your input is invalid. Please try again!");
            goto tryAgain1;
        }

        //LIST OF STRINGS    
    
        tryAgain2:
        
        // declaring the LIST of STRINGS (no size required).
        List<string> strList = new List<string>()
        { "lion", "leopard", "tiger", "elephant", "rhinoceros", "giraffe", "zebra", "warthog"}; //Adding elements to the List
        
        //collecting user keyboard input of List index selection.
        Console.WriteLine("Enter your STRING LIST index selection (0 - 7): ");
        int listIndex = Convert.ToInt32(Console.ReadLine());
        
        try
        {
            string indexStr = strList[listIndex];
            Console.WriteLine("You selected the index: " + listIndex);
            Console.WriteLine();

            Console.WriteLine("Your animal selection is: ");
            Console.WriteLine(indexStr);
            Console.ReadLine();
        }

        catch
        {
            Console.WriteLine("Your input is invalid. Please try again!");
            Console.WriteLine();
            goto tryAgain2;
        }        
    }              
}


