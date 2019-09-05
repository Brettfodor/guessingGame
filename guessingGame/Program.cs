using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please enter a number.");

            string number = Console.ReadLine();

            bool seven = number.Equals("7");
            bool zero = number.Equals("0");

            switch (number)
            {
                case "7":
                    Console.WriteLine("You have won the game");
                    break;

                case "0":
                    Console.WriteLine("Your number is a bit low");
                    break;

                default:
                    Console.WriteLine("You Lose");
                    break;

            }
        }
    }
}
