using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //I can't help but wonder if there's a more elegant way
            //to do the optional goals, because this code is a nightmare
            //with its constant checks for repeat/quit. I thought about 
            //using gotos but I know that's kind of a bad habit.

            //play is set to true to enter the main while loop.
            //The variable is set to false when the user wants to quit.
            bool play = true;
            bool quit = false;      //Different from "play" to allow for a quit message.
            bool restart = false;

            while (play == true)
            {
                //PART 1 -- INPUT

                //Gets the user's first name.
                Console.WriteLine("Enter your first name.");
                string firstName = Console.ReadLine();
                Console.Clear();
                
                //Checks firstName for exit or restart.
                if (firstName.ToLower() == "quit")
                {
                    quit = true;
                }
                if (firstName.ToLower()=="restart")
                {
                    restart = true;
                }

                //Gets the user's last name.
                //From this point on, all code will be within if statements
                //to check if a quit or a restart has been used.
                //The string is declared beforehand so it's in the context
                //outside of the logical statement.
                string lastName = "";
                if (quit == false && restart == false)
                {
                    Console.WriteLine("Enter your last name.");
                    lastName = Console.ReadLine();
                    Console.Clear();

                    //Checks for quit or restart.
                    if (lastName.ToLower() == "quit")
                    {
                        quit = true;
                    }
                    if (lastName.ToLower() == "restart")
                    {
                        restart = true;
                    }
                }

                //Gets the user's age. It's initally stored as a string
                //to check for quit or restart.
                int age = 0;
                if (quit == false && restart == false)
                {
                    Console.WriteLine("Enter your age.");
                    string ageInput = (Console.ReadLine());
                    Console.Clear();

                    //Checks for quit or restart.
                    if (ageInput.ToLower() == "quit")
                    {
                        quit = true;
                    }
                    if (ageInput.ToLower() == "restart")
                    {
                        restart = true;
                    }

                    //We have to do another quit/restart check to make sure
                    //it doesn't crash when it tries to parse the string into an int/
                    if (quit == false && restart == false)
                    {
                        //Once we know it's not a quit or exit, we make an int variable.
                        age = int.Parse(ageInput);

                        //Ensures the user's age isn't negative.
                        while (age < 0 && quit == false && restart == false)
                        {
                            Console.WriteLine("Your age can't be negative.");
                            Console.WriteLine("Enter your age.");
                            ageInput = (Console.ReadLine());
                            Console.Clear();

                            //Checks for quit or restart.
                            if (ageInput.ToLower() == "quit")
                            {
                                quit = true;
                            }
                            else if (ageInput.ToLower() == "restart")
                            {
                                restart = true;
                            }
                            else
                            {
                                age = int.Parse(ageInput);
                            }
                        }
                    }
                }

                //Gets the user's birth month.
                //The string is declared beforehand so it's in the context
                //outside of the logical statement.
                string birthMonth = "";
                if (quit == false && restart == false)
                {
                    Console.WriteLine("Enter your birth month.");
                    birthMonth = Console.ReadLine().ToLower();
                    Console.Clear();

                    //Checks for quit or restart.
                    if (birthMonth.ToLower() == "quit")
                    {
                        quit = true;
                    }
                    if (birthMonth.ToLower() == "restart")
                    {
                        restart = true;
                    }

                    //Ensures the user's birth month is valid.
                    //The quit and restart logic are also in the loop conditions.
                    while (birthMonth != "january" && birthMonth != "february" && birthMonth != "march"
                        && birthMonth != "april" && birthMonth != "may" && birthMonth != "june"
                        && birthMonth != "july" && birthMonth != "august" && birthMonth != "september"
                        && birthMonth != "october" && birthMonth != "november" && birthMonth != "december"
                        && quit == false && restart == false)
                    {
                        Console.WriteLine("Invalid month.");
                        Console.WriteLine("Enter your birth month.");
                        birthMonth = Console.ReadLine().ToLower();
                        Console.Clear();

                        if (birthMonth.ToLower() == "quit")
                        {
                            quit = true;
                        }
                        if (birthMonth.ToLower() == "restart")
                        {
                            restart = true;
                        }
                    }
                }

                //Gets the user's favorite color.
                //The string is declared beforehand so it's in the context
                //outside of the logical statement.
                string ROYGBIV = "";
                if (quit == false && restart == false)
                {
                    Console.WriteLine("Enter your favorite ROYGBIV color.");
                    Console.WriteLine("(Enter \"Help\" for information.)");
                    ROYGBIV = Console.ReadLine().ToLower();
                    Console.Clear();

                    //Checks for quit or restart.
                    if (ROYGBIV.ToLower() == "quit")
                    {
                        quit = true;
                    }
                    if (ROYGBIV.ToLower() == "restart")
                    {
                        restart = true;
                    }

                    //Ensures the user's favorite color is valid, or displays the help screen if appropriate.
                    //The quit and restart logic are also in the loop conditions.
                    while (ROYGBIV != "red" && ROYGBIV != "orange" && ROYGBIV != "yellow"
                        && ROYGBIV != "green" && ROYGBIV != "blue" && ROYGBIV != "indigo"
                        && ROYGBIV != "violet" && quit == false && restart == false)
                    {
                        if (ROYGBIV == "help")
                        {
                            Console.WriteLine("The ROYGBIV colors are red, orange, yellow, green, blue, indigo, and violet.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid color. Enter \"Help\" for information.");
                        }

                        Console.WriteLine("Enter your favorite ROYGBIV color.");
                        ROYGBIV = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (ROYGBIV.ToLower() == "quit")
                        {
                            quit = true;
                        }
                        if (ROYGBIV.ToLower() == "restart")
                        {
                            restart = true;
                        }
                    }
                }

                //Gets the user's number of siblings.
                //It's declared outside the logical statement to be in the proper context.
                int siblings = -1;
                if (quit == false && restart == false)
                {
                    Console.WriteLine("Enter how many siblings you have.");
                    //It's read as a string first to check for quit/restart.
                    string siblingInput = Console.ReadLine();
                    Console.Clear();

                    if (siblingInput.ToLower() == "quit")
                    {
                        quit = true;
                    }
                    if (siblingInput.ToLower() == "restart")
                    {
                        restart = true;
                    }

                    if (quit == false && restart == false)
                    {

                        siblings = int.Parse(siblingInput);
                        //Ensures the number of siblings isn't negative.
                        while (siblings < 0 && quit == false && restart == false)
                        {
                            Console.WriteLine("You can't have negative siblings.");
                            Console.WriteLine("Enter how many siblings you have.");
                            siblingInput = Console.ReadLine();
                            Console.Clear();
                            if (siblingInput.ToLower() == "quit")
                            {
                                quit = true;
                            }
                            else if (siblingInput.ToLower() == "restart")
                            {
                                restart = true;
                            }
                            else
                            {
                                siblings = int.Parse(siblingInput);
                            }
                        }
                    }
                }

                //Thankfully, we can now skip over the rest of the program
                //in one huge if statement if we do have a quit/restart.

                if (quit == false && restart == false)
                {
                    //PART 2 -- DETERMINING OUTPUT

                    //If your age is an odd number, you've gotta serve more time.
                    int retireIn;
                    if (age % 2 == 0)
                    {
                        retireIn = 30;
                    }
                    else
                    {
                        retireIn = 50;
                    }

                    //Determines retirement location based on number of siblings.
                    string location;
                    if (siblings == 0)
                    {
                        location = "Melbourne, Australia";
                    }
                    else if (siblings == 1)
                    {
                        location = "Tokyo, Japan";
                    }
                    else if (siblings == 2)
                    {
                        location = "New York, New York";
                    }
                    else if (siblings == 3)
                    {
                        location = "Paris, France";
                    }
                    else
                    {
                        location = "Los Angeles, California";
                    }

                    //Determines vehicle based on favorite ROYGBIV color.
                    string vehicle = "";
                    switch (ROYGBIV)
                    {
                        case "red":
                            vehicle = "Ferrari LaFerrari";
                            break;
                        case "orange":
                            vehicle = "Lamborghini Aventador";
                            break;
                        case "yellow":
                            vehicle = "Porsche 911 Turbo S";
                            break;
                        case "green":
                            vehicle = "Nissan GT-R";
                            break;
                        case "blue":
                            vehicle = "Corvette ZR1";
                            break;
                        case "indigo":
                            vehicle = "Audi R8";
                            break;
                        case "violet":
                            vehicle = "Mercedes Benz SLS AMG";
                            break;
                        default:
                            Console.WriteLine("Something broke.");
                            Console.ReadKey();
                            break;
                    }

                    //charNum is the variable that determines which, if any,
                    //characters in the birth month are found in the first and last name.
                    int charNum = -1;

                    //Outer loop iterates the first three characters of birthMonth.
                    //The loop also ends if a character match is found,
                    //so that subsequent matches don't overwrite the first.
                    for (int x = 0; x <= 2 && charNum < 0; x++)
                    {
                        //Inner loops check firstName...
                        for (int y = 0; y < firstName.Length; y++)
                        {
                            if (birthMonth.Substring(x, 1) == firstName.ToLower().Substring(y, 1))
                            {
                                charNum = x;
                            }
                        }

                        //...and lastName for matches with the birthMonth characters.
                        for (int y = 0; y < lastName.Length; y++)
                        {
                            if (birthMonth.Substring(x, 1) == lastName.ToLower().Substring(y, 1))
                            {
                                charNum = x;
                            }
                        }
                    }

                    int bankAccount = 0;

                    if (charNum == -1)
                    {
                        bankAccount = 1000000;
                    }
                    else if (charNum == 0)
                    {
                        bankAccount = 2000000;
                    }
                    else if (charNum == 1)
                    {
                        bankAccount = 3000000;
                    }
                    else if (charNum == 2)
                    {
                        bankAccount = 4000000;
                    }
                    else
                    {
                        Console.WriteLine("Something broke.");
                        Console.ReadKey();
                    }

                    //PART 3 -- OUTPUT
                    Console.WriteLine($"{firstName} {lastName} will retire in {retireIn} years with {String.Format("{0:C0}", bankAccount)} in the bank, a vacation home in {location}, and a {vehicle}.");
                    Console.WriteLine("Play again?");
                    string playAgain = Console.ReadLine().ToLower();
                    Console.Clear();

                    if (playAgain != "yes")
                    {
                        play = false;
                    }
                }

                //If the user quit, displays the quit message
                //and sets the loop not to continue.
                if (quit == true)
                {
                    play = false;
                    Console.WriteLine("Nobody likes a quitter...");
                    Console.ReadKey();
                }

                //If restart is chosen, the variable is reset,
                //and it returns to the beginning of the loop.
                if (restart == true)
                {
                    restart = false;
                }

            }
        }
    }
}
