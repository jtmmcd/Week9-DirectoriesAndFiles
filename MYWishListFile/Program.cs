using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MYWishListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Programmeerimine\Failid\wishList";
            string fileName = @"\\myWishList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishlist = arrayFromFile.ToList<string>();

            bool loopActive = true;
            while(loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myWishlist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take Care!");
                }
            }

            Console.Clear();

            foreach(string wish in myWishlist)
            {
                Console.WriteLine($"Your wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishlist);






        }
    }
}
