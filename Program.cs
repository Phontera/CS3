using System.Runtime.InteropServices;
using System;

namespace Csharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 4; 
            int guess = 0; 
            int randomNumber = 0; 
            bool win = false;
            string levelOne = "Easy";
            string levelTwo = "Medium";
            string levelThree = "Hard";

            //Level selection
            
            Console.WriteLine("Welcome to Guessing Wizard Pick a Level by typing Easy, Medium or Hard: "); 
            
            levelOne = Console.ReadLine();
            Console.Write("Hello welcome to " + levelOne); 

            levelTwo = Console.ReadLine();
            Console.Write("Hello welcome to " + levelTwo); 

            levelThree = Console.ReadLine();
            Console.Write("Hello welcome to " + levelThree);

    
    do
    
    { 
        Console.WriteLine("welcome to Guess Wizard! Guess a Number between 1 and 10: "); 

        //Conversion of variable types
        
        secretNumber = int.Parse(Console.ReadLine());
        guess = int.Parse(Console.ReadLine()); 
        randomNumber = int.Parse(Console.ReadLine()); 

        if (guess > secretNumber) 
            { 
                Console.Write("That was wrong!"); 
            }
        else if (guess < secretNumber) 
            { 
                Console.Write("That was wrong!"); 
            }
        else if (guess == randomNumber) 
            { 
                Console.Write("There are 3 levels, easy, medium and hard"); 
            }
        else if (guess == secretNumber) 
            { 
                Console.Write("You got it right!"); 
                win = true; 
        
            }

        }while(win == false); 
        

        
        
        
        }
    }
}
