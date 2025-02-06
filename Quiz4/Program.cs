using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    internal class Program
    {
        static int RollDice()
        {
            int returnValue = 0;
            int x = 0;
            return 5 + x;
        }

        static void Main(string[] args)    
        {
            //welcome user
            Console.WriteLine("Welcome to the Rolling Game!");
            //prompt user to enter a number between 1 and 6
            Console.WriteLine("Enter a number between 1 and 6(or type 'Quit' to exit):3");
            int rollnumber = Convert.ToInt32(Console.ReadLine());
            //let user know the dice is rolling 
            Console.WriteLine("Rolling the dice...");
            //method for dice to roll
            string rolldice = Console.ReadLine();

            Console.WriteLine("You rolled a: " + int.Parse(Console.ReadLine()));

            Console.WriteLine("You lose! Try again.");

            Console.WriteLine(" Enter a number between 1 and 6 (or type 'Quit' to exit): Quit");       
        }
    }
}
