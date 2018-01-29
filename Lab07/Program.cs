using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }

        private static void GetUserInput()
        {
            Console.WriteLine("Enter in text you want translated to Pig Latin:");
            string userInput = Console.ReadLine();
        }


        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInput();
            }
        }
    }
}
