using System;

namespace Casting_Mcvey_Zander
{
    class Program
    {
        static void Main(string[] args)
        {   // Asks user to enter a whole nmber and assigns input to integer.
            Console.WriteLine("Please enter a whole number, for the sake of the world...");
            int myFavNum = Convert.ToInt32(Console.ReadLine());
            
            // Prints favorite number to console, FOR THE WORLD!
            Console.WriteLine("Your favorite number is " + myFavNum);

            // Asks user a true/false question and assigns response to a boolean, asking if you want to save the world.
            Console.WriteLine("Would you like to save the world? (Please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            //Print the result of question asked below. (Dew it)
            Console.WriteLine($"You said {isTrue}, I see.");
           
            //The system starts to die off, your adventure has just begun it seems.
            Console.WriteLine("That is very, very...");
            Console.WriteLine("Interesting");
                
        }
    }
}
