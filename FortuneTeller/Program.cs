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

            Console.WriteLine("Enter your birth month.");
            string birthMonth = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your favorite ROYGBIV color. (Enter \"Help\" for information.)");
            string ROYGBIV = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter how many siblings you have.");
            int siblings = int.Parse(Console.ReadLine());
            Console.Clear();

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
            else
            {
                location = "Paris, France";
            }



        }
    }
}
