using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Liigyear
{
    class Program
    {
        static void Main(string[] args)
        {


            /*int yearOfBirth;

            Console.WriteLine("Enter your year of birth:");
            yearOfBirth =Int32.Parse(Console.ReadLine());
            
            if (yearOfBirth % 4 == 0)
            {
                Console.WriteLine($"{yearOfBirth} was a Leap year");
            }
            else
            {
                Console.WriteLine($"{yearOfBirth} was not a leap year");
            }
            Console.ReadLine();

            //ternary operatior
            string answer = (yearOfBirth % 4 == 0) ? "Leap year" : "Not a leap year";
            Console.WriteLine(answer);
            Console.ReadLine();*/

            Console.WriteLine("what is your choise. whiskey or wine");
            string userChoice = Console.ReadLine();
            string choice = userChoice == "whiskey" ? "Here is your whiskey." : "Here is your wine.";
            Console.WriteLine(choice);
            Console.ReadLine();




        }






    }
    
}
