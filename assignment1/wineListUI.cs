using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class wineListUI
    {
        public static int GetUserInput()
        {
            wineListUI.printMenu();

            string invoke = Console.ReadLine();

            while (invoke != "1" && invoke != "2")
                {
                Console.WriteLine("Please input a valid number either 1 or 2");
                Console.WriteLine();

                wineListUI.printMenu();
                if (invoke == "1")
                {
                    
                }
            }
            return int.Parse(invoke);
        }

        public static void DisplayOutput (string output)
        {
            Console.WriteLine(output);
        }
        private static void printMenu()
    {
        Console.WriteLine("What is your decision?");
        Console.WriteLine("1. Show what wines we have available.");
        Console.WriteLine("2. Exit");
    }
       
    }
   
}
