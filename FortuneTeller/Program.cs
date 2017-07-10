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
                // Ask user for input
           
                Console.WriteLine("Hello and welcome to Fortune Teller 6.0! Press the enter key to continue!");
                Console.ReadLine();
                

                Console.WriteLine("Please start by entering your first name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("\n" + firstName + "? That is a nice name! Do you have a last name?");
                string lastName = Console.ReadLine();

                Console.WriteLine("\n" + "Well, " + firstName + " " + lastName + ", I am going to read you your fortune, but first i will need to  know just a little bit more about you. How old are you?");
                string yourAge = Console.ReadLine();

                Console.WriteLine("\n" + "Wow you dont look that old! Please enter the number of the month you were born  in:");
                int birthMonth = int.Parse(Console.ReadLine());


                if (birthMonth == 1)
                // could not get ROYGBIV to come up as options for "help"
                {
                    Console.WriteLine("\n" + "January huh? Where im from its really cold that time of year! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    //problem
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }

                else if (birthMonth == 2)
                {
                    Console.WriteLine("\n" + "February? I dont meet very many people with that birthday month! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 3)
                {
                    Console.WriteLine("\n" + "March birthday? I love that month! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 4)
                {
                    Console.WriteLine("\n" + "April! Thats when i was born! Now please tell me your favorite ROYGBIV(for      ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 5)
                {
                    Console.WriteLine("\n" + "I love May. That means summer is around the corner! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 6)
                {
                    Console.WriteLine("\n" + "June! What a great month! Now please tell me your favorite ROYGBIV(for ROYGBIV   color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 7)
                {
                    Console.WriteLine("\n" + "July? One of my favorite holidays is in that month! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 8)
                {
                    Console.WriteLine("\n" + "I have a son born in August! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 9)
                {
                    Console.WriteLine("\n" + "September? Thats interesting! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 10)
                {
                    Console.WriteLine("\n" + "October? I love halloween! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 11)
                {
                    Console.WriteLine("\n" + "November! I love thanksgiving! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }
                else if (birthMonth == 12)
                {
                    Console.WriteLine("\n" + "December baby? Thats usually when the snow starts falling here! Now please tell me your favorite ROYGBIV(for ROYGBIV color options type \"help\") color to continue:");
                    string help = Console.ReadLine();
                    Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                    Console.ReadLine();
                }

                Console.WriteLine("\n" + "Thats a great color! One last question...How many siblings do you have?");
                int numOfSiblings = int.Parse(Console.ReadLine());

                Console.WriteLine("\n" + "Based on the information you have given me i will now calculate your future.....Please press enter to see your fortune!");


                string vacationHome = Console.ReadLine();
                if (numOfSiblings == 0)
                {
                    Convert.ToString(vacationHome = "Jamaca");
                }
                if (numOfSiblings == 1)
                {
                    Convert.ToString(vacationHome = "France");
                }
                if (numOfSiblings == 2)
                {
                    Convert.ToString(vacationHome = "Italy");
                }
                if (numOfSiblings == 3)
                {
                    Convert.ToString(vacationHome = "Africa");
                }
                if (numOfSiblings >= 3)
                {
                    Convert.ToString(vacationHome = "Mexico");
                }
                if (numOfSiblings <= 0)
                {
                    Convert.ToString(vacationHome = "Ohio");
                }
                Console.WriteLine(firstName + " " + lastName + " " + "will have a vacation home in" + " " + vacationHome);
            
            


            

            
                
                    }
    
    }
}
