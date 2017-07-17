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

            Console.WriteLine("Welcome to Fortune Teller 6.0! please start by entering your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Thats an interesting name! Please enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of month in which you were born:");
            string birth = Console.ReadLine();
            string color;
            while (true)
            {
                Console.WriteLine("What is your favorite ROYGBIV color?. Please enter help for ROYGBIV colors");  //for some reason escape characters arnt working
                color = Console.ReadLine();

                if (color.ToLower() == "help")
                {

                    Console.WriteLine("ROYGBIV = Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                }
                else if (color.ToLower() == "red")
                {
                    break;
                }
                else if (color.ToLower() == "orange")
                {
                    break;
                }
                else if (color.ToLower() == "yellow")
                {
                    break;
                }
                else if (color.ToLower() == "green")
                {
                    break;
                }
                else if (color.ToLower() == "blue")
                {
                    break;
                }
                else if (color.ToLower() == "indigo")
                {
                    break;
                }
                else if (color.ToLower() == "violet")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a color!");

                }

            }

            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());


            Random rand = new Random();
            int retireYear, moneyInBank;

            string location;
            if (age % 2 == 0)
            {
                retireYear = rand.Next(10, 20);
            }
            else
            {
                retireYear = rand.Next(20, 30);
            }
            if (siblings == 0)
            {
                location = "Ohio";
            }
            else if (siblings == 1)
            {
                location = "Hawii";
            }
            else if (siblings == 2)
            {
                location = "The Bahamas";
            }
            else if (siblings == 3)
            {
                location = "Jamaca";
            }
            else
            {
                location = "Puerto Rico";
            }
            string transportation;
            if (color.ToLower() == "red" || color.ToLower() == "violet")
            {
                transportation = "Corvette";
            }
            else if (color.ToLower() == "orange" || color.ToLower() == "indigo")
            {
                transportation = "Honda Civic";
            }
            else if (color.ToLower() == "blue" || color.ToLower() == "yellow")
            {
                transportation = "Viper";
            }
            else
            {
                transportation = "Lambo";
            }

            if ((firstName.ToLower().Contains(birth[0])) || (lastName.ToLower().Contains(birth[0])))
            {
                moneyInBank = rand.Next(10000, 20000);
            }
            else if (firstName.ToLower().Contains(birth[1]) || lastName.ToLower().Contains(birth[1]))
            {
                moneyInBank = rand.Next(15000, 25000);
            }
            else if (firstName.ToLower().Contains(birth[2]) || lastName.ToLower().Contains(birth[2]))
            {
                moneyInBank = rand.Next(25000, 35000);
            }
            else
            {
                moneyInBank = rand.Next(50000, 70000);
            }

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireYear + " of years with $" + moneyInBank + " in the bank, a vacation home in " + location + " and a " + transportation);



        }
    }
}
