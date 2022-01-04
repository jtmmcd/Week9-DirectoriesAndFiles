using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListItems
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Programmeerimine\Failid\ShoppingList";
            string fileName = @"\\ShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Would you like to add something to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take Care!");
                }
            }

            Console.Clear();



            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}
