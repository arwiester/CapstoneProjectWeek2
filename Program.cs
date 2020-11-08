using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectedCountry;

            // Prints welcome message to user
            Console.WriteLine($"Welcome to the Vacation Budget Planner!");
            
            //Asks user for their name and saves it as a string variable
            Console.WriteLine($"Please enter your name:");
            string userName = Console.ReadLine();

            //Welcome message and travel option 
            Console.WriteLine($"Welcome {userName}! Please enter the country you want go to? Jamaica or Mexico"); 
            selectedCountry = Console.ReadLine();

            //Assumes Jamacia for now
            //Accounts for the various ways a user could typically enter in Jamica
            //If user enters Mexico then they get a 'not ready' message and exits
            bool jamaicaLower = selectedCountry.Equals("jamaica");
            bool jamaicaUpper = selectedCountry.Equals("JAMAICA");
            if (selectedCountry.Equals("Jamaica") || jamaicaLower || jamaicaUpper)
            {
                //Asks how many days the user wants to stay
                Console.WriteLine($"How many days do you want to stay at {selectedCountry}?");             

            }
            else
            {
                Console.WriteLine($"We have not built out the application for Mexico yet. Try again later. Press enter to close.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }
             
            //Stores and converts the days the user wants to stay
            int daysToStay = Convert.ToInt32(Console.ReadLine());

            //Asks how much spending money they will bring
            Console.WriteLine("How much spending money would you like to take?");
            double spendingMoney = Convert.ToDouble(Console.ReadLine());
            
            //Calculates amount user can spend per day
            double spendingPerDay = (spendingMoney / daysToStay);
            Console.WriteLine(spendingPerDay.ToString("C"), "{0:0,0.00}", spendingPerDay);
            
            //Summary message 
            Console.WriteLine($"Hey {userName}, you are going to {selectedCountry} for {daysToStay} days with " + (spendingMoney.ToString("C")) + " for spending money. You can spend " + (spendingPerDay.ToString("C")) + " per day.");
            
            Console.ReadLine();
           
        }
    }
}
