using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//KM Ramela 
// 221001482
// color program the user must guess the correct color to win 

namespace Problem_color2._0 
{
    internal class Program
    {
         static string Colorchoice,name,choice; // variables 
        static void Main()
        {

            HouseKeeping(); // this calls the  housekeeping method 
        }
        static void HouseKeeping()
        {
            // houskeeping method strat by welcoming the user to the game  before asking the ser if they want to play 
            Console.WriteLine("welcome to the color game ");
            Console.WriteLine("to play the game you  Must enter the first letter as a capital letter ");
            Console.WriteLine("Wish you all the best ");
            // this clears the screen before the question asked to the  user 
            Console.Clear();   
            //ask the user their name to be used in the major question 
            Console.WriteLine("Welcome to color game please enter your name  ");
            Console.WriteLine("");
            //ask the user the question if they would like to play and echo it back to be used in the decision statement
            name = Console.ReadLine();
            Console.WriteLine(" {0} would like to play Y/N or type Exit to leave the program" ,name);
            choice = Console.ReadLine();
            // a decison statement used to after echoing the user  inpute  and calls the specific method the user requested 
            switch (choice)
            {
                case "Y":
                    detailedLoop(); 
                    break;
                case "N":
                    FinishUp();
                    break;
                case "Exit":
                    FinishUp();
                    break;
                default:
                    FinishUp();
                    break;

            }

        }
        static void detailedLoop()
        {
            // this is the game question to the user and its echoed back to run the while loop 
            Console.WriteLine("{0} Please enter color choice ",name);
            Colorchoice = Console.ReadLine();
            
            //whhile loop that depents on the question above and excute the relevent output 
            while (Colorchoice == "Red" || Colorchoice == "Blue" || Colorchoice == "Green" )
            {
                // a decision statement used to chooses the relevent output to the user with the color they choose assuming the answer is correct
                switch (Colorchoice)
                {
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.Red;    
                        Console.WriteLine("Congrats your color is Red ");

                        break;
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congrats your color is Green ");

                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Congrats your color is Blue ");

                        break;
                    default:
                        Console.WriteLine("incorrect the program will exit ");
                        Console.ReadKey();
                        FinishUp();
                        break;
                }
                // this question is a key to exit the loop if the user decide if they dont want to play anymore and its followed by the decision statement to show the correct output to the user 
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("would you like to  again press Y/N ");
                Colorchoice = Console.ReadLine();
                switch (Colorchoice)
                {
                    case "Y":
                        detailedLoop();
                        break;
                    case "N":
                        FinishUp();
                        break;
                    default:
                        Console.WriteLine("incorrect  the program will return to the main menu ");
                        Main();
                        break;

                }
            }
        }
        static void FinishUp()
        {
            // clears the screen before they exit the program 
            Console.Clear();
            Console.WriteLine("Thank you for playing,press anykey to exit... ");
            Console.ReadKey();
            // I would be happy to receive a feedback from this thank you 
        }
    }
}
