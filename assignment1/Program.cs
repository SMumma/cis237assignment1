//Class: CIS237 Advanced C# Programming
//Author: Susan Mumma
//Date: 09/21/2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment1
{

    class Program
    {
        public static string itemsList;
        public string wineListItems;
        static void Main(string[] args)
        {

            WineListCollection[] wineListItems = new WineListCollection[100];
//Grabbing the user input and converting it to a string to be used later.
            int decision = wineListUI.GetUserInput();
            string invoke = decision.ToString();
            while (invoke != "2")
            {
                if (invoke == "1")
                {
                    string ListOutput = "";
                    
                    foreach (WineListCollection itemlist in wineListItems)
                    {

                        //Theoretically supposed to grab select fields from the CSV provided to allow the list to appear.
                       if (itemlist != null)
                        {
                           Console.WriteLine(ListOutput = itemlist.Id + " " + itemlist.Name + " " + itemlist.Cost);
                            Console.WriteLine(ListOutput);
                        }
                    }
                }
                else
                {
                    if (invoke == "2")
                    {
                        Console.WriteLine("Goodbye");
                        Console.WriteLine();
                    }
                }
            }
           ImportCSV("WineList.csv", wineListItems);
        }
        public static bool ImportCSV(string CSVFile, WineListCollection[] wineListItems)
        {
            StreamReader streamReader = null;

            try
            {
                int increments = 0;

                //Displays the items and name of said items if one selects the option 1.
                while ((itemsList = streamReader.ReadLine()) == "1")
                {   Console.WriteLine("Items: " + wineListItems);
                    Console.WriteLine("Name: " + wineListItems);
                    Console.WriteLine();
                    increments++;
                }
                return true;
            }
            catch (Exception e)
            {
                //Displays the error that it caught.
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                if (streamReader != null)
                {
                    //Streamreader closes down if some value is provided.
                    streamReader.Close();
                }
            }
        }
//Item is built to display id, name and cost.
        static void itemProcesses(string readItem, WineListCollection[] wineListItems, int index)
        {
            string[] split = readItem.Split(',');
            string id = split[0];
            string name = split[1];
            int cost = Int32.Parse(split[2]); 
            wineListItems[index] = new WineListCollection(id, name, cost);
        }
    }
}
