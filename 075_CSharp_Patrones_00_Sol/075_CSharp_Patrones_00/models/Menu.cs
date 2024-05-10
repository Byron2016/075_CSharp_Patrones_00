using _075_CSharp_Patrones_00.models._07_DecoratorPattern.Ejem_002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_CSharp_Patrones_00.models
{
    public static class Menu
    {
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit");
            Console.WriteLine("7) Prototype Patron");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    //ReverseString();
                    return true;
                case "2":
                    //RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                case "7":
                    Ejem_002.ExecuteEjem_002();
                    return true;
                default:
                    return true;
            }
        }
    }
}
