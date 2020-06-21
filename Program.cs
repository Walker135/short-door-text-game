using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
      Console.WriteLine("\n");

      // noise choice
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.WriteLine("Type YES or No: ");
      string noiseChoice = Console.ReadLine().ToUpper();
      
      bool expectedInput = true;
      while(expectedInput)
      {
        if (noiseChoice == "NO")
          {
            Console.WriteLine("\n");
            Console.WriteLine("Not much of an adventure if we don't leave our room! \nTHE END.");
            expectedInput = false;
          }
        else if (noiseChoice == "YES")
          {
            Console.WriteLine("\n");
            Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. \nYou walk towards it. Do you open it or knock?");
          expectedInput = false;
          }
        else
         { 
            Console.WriteLine("Please Type YES or NO: ");
            noiseChoice = Console.ReadLine().ToUpper();
          }
      }

      // Door choice
      Console.Write("Type OPEN or KNOCK: ");
      string doorChoice = Console.ReadLine().ToUpper();

      expectedInput = true;
      while(expectedInput)
      {
        if (doorChoice == "KNOCK")
          {
        // Riddle Choice
            Console.WriteLine("\n");
            Console.WriteLine("A voice behind the door speaks. It says, \n\"Answer this riddle: \"\n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
            Console.Write("Type your answer: ");
            string riddleAnswer = Console.ReadLine().ToUpper();
            if (riddleAnswer == "NOTHING")
              {
                Console.WriteLine("\n");
                Console.WriteLine("The door opens and NOTHING is there. \nYou turn off the light and run back to your room and lock the door. \nTHE END.");
              }
            else
              {
                Console.WriteLine("\n");
                Console.WriteLine("You answered incorrectly. The door doesn't open. \nTHE END.");
              }
            expectedInput = false;
          }
        else if (doorChoice == "OPEN")
          {
        // Key Choice
            Console.WriteLine("\n");
            Console.WriteLine("The door is locked! See if one of your three keys will open it.");
            Console.WriteLine("Enter a number (1-3): ");
            string keyChoice = Console.ReadLine().ToUpper();

            bool expectedInputKey = true;
            
            while(expectedInputKey)
            {
              switch (keyChoice)
              {
                case "1":
                  Console.WriteLine("\n");
                  Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. \nStrange... \nTHE END.");
                  expectedInputKey = false;
                  break;

                case "2":
                  Console.WriteLine("\n");
                  Console.WriteLine("You choose the second key. The door doesn't open. \nTHE END.");
                  expectedInputKey = false;
                  break;

                case "3":
                  Console.WriteLine("\n");
                  Console.WriteLine("You choose the third key. The door doesn't open. \nTHE END.");
                  expectedInputKey = false;
                  break;

                default:
                  Console.WriteLine("\n");
                  Console.WriteLine("Please type a number between 1-3: ");
                  keyChoice = Console.ReadLine().ToUpper();  
                  break;
              }
            }
            expectedInput = false;
          }
        
        else
        {
          Console.WriteLine("\n");
          Console.Write("Please type OPEN or KNOCK: ");
          doorChoice = Console.ReadLine().ToUpper();
        }
      }   
    }
  }
}



