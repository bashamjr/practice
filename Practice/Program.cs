using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
          
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = mainMenu();
            }
            
        }

        private static bool mainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option");
            Console.WriteLine("Option 1");
            Console.WriteLine("Option 2");
            Console.WriteLine("Option 3 Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                printNumbers();
                return true;
            }
            else if (result == "2")
            {
                guessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
          
            }
            else
            {
                return true;
            }
        }

        private static void printNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers!");
            Console.Write("Type a Number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void guessingGame()
        {
            Console.WriteLine("Guessing Game");
            Random myRandomNumber = new Random();
            int randomNumber = myRandomNumber.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

            } while (incorrect);
            Console.WriteLine("Correct! it took you {0} guesses.", guesses);

            Console.ReadLine();
        }
    }
}
