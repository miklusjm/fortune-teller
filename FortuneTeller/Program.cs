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

            Console.WriteLine("Enter your first name.");
            string firstName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your last name.");
            string lastName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your age.");
            int age = int.Parse(Console.ReadLine());
            Console.Clear();

            while(age < 0)
            {
                Console.WriteLine("Your age can't be negative.");
                Console.WriteLine("Enter your age.");
                age = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Enter your birth month.");
            string birthMonth = Console.ReadLine().ToLower();
            Console.Clear();

            while (birthMonth != "january" && birthMonth != "february" && birthMonth != "march"
                && birthMonth != "april" && birthMonth != "may" && birthMonth != "june"
                && birthMonth != "july" && birthMonth != "august" && birthMonth != "september"
                && birthMonth != "october" && birthMonth != "november" && birthMonth != "december")
            {
                Console.WriteLine("Invalid month.");
                Console.WriteLine("Enter your birth month.");
                birthMonth = Console.ReadLine().ToLower();
                Console.Clear();
            }

            Console.WriteLine("Enter your favorite ROYGBIV color.");
            Console.WriteLine("Enter \"Help\" for information.)");
            string ROYGBIV = Console.ReadLine().ToLower();
            Console.Clear();

            while (ROYGBIV != "red" && ROYGBIV != "orange" && ROYGBIV != "yellow"
                && ROYGBIV != "green" && ROYGBIV != "blue" && ROYGBIV != "indigo"
                && ROYGBIV != "violet")
            {
                if (ROYGBIV == "help")
                {
                    Console.WriteLine(@"The ROYGBIV colors are red, orange, yellow,
                        green, blue, indigo, and violet.");
                }
                else
                {
                    Console.WriteLine("Invalid color.");
                    Console.WriteLine("Enter your favorite ROYGBIV color.");
                    Console.WriteLine("Enter \"Help\" for information.)");
                    ROYGBIV = Console.ReadLine().ToLower();
                    Console.Clear();
                }
            }

            Console.WriteLine("Enter how many siblings you have.");
            int siblings = int.Parse(Console.ReadLine());
            Console.Clear();

            while (siblings <0)
            {
                Console.WriteLine("You can't have negative siblings.");
                Console.WriteLine("Enter how many siblings you have.");
                siblings = int.Parse(Console.ReadLine());
            }

            //PART 2 -- DETERMINING OUTPUT

            int retireIn;
            if (age % 2 == 0)
            {
                retireIn = 30;
            }
            else
            {
                retireIn = 50;
            }

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

            string vehicle;
            switch (ROYGBIV)
            {
                case "red":
                    vehicle = "Ferrari LaFerrari";
                    break;
                case "orange":
                    vehicle = "Lamborghini Aventador";
                    break;
                case "yellow":
                    vehicle = "Porsche 911";
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

            int charNum = -1;

            for (int x = 0; x <= 2 && charNum < 0; x++)
            {
                for (int y = 0; y <= firstName.Length; y++)
                {

                }
            }




               



        }
    }
}
