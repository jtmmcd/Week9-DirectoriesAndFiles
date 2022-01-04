using System;
using System.IO;

namespace ShoppingListCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Programmeerimine\Failid";
            Directory.CreateDirectory($"{rootDirectory}\\ShoppingList");
            File.Create($"{rootDirectory}\\ShoppingList\\ShoppingList.txt");
        }
    }
}
