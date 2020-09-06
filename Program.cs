using System;
using System.Collections.Generic;

namespace GotoStatementExample
{
    class Program
    {
        public enum CoffeeSize
        {
            Small,
            Medium,
            Large
        }

        public static int ComputeTotal(CoffeeSize coffee)
        {
            int total = 0;
            switch (coffee)
            {
                case CoffeeSize.Small:
                    total += 25;
                    break;
                case CoffeeSize.Medium:
                    total += 25;
                    goto case CoffeeSize.Small;
                case CoffeeSize.Large:
                    total += 50;
                    goto case CoffeeSize.Small;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
            return total;
        }

        public static void BreakLoopUsingGoto()
        {
            
            List<int> values = new List<int>() { 1, 2, 3, 4, 5 };
            int searchValue=4;
            foreach(var item in values){
                if(item==searchValue){
                    goto EndLoop;
                }
            }
            System.Console.WriteLine("Seaech value {0} Not Found",searchValue);
            EndLoop:
            System.Console.WriteLine("Found the value {0} inside the list",searchValue);
        }
        static void Main(string[] args)
        {

            System.Console.WriteLine("Price of small coffee {0}", ComputeTotal(CoffeeSize.Small));
            System.Console.WriteLine("Price of medium coffee {0}", ComputeTotal(CoffeeSize.Medium));
            System.Console.WriteLine("Price of large coffee {0}", ComputeTotal(CoffeeSize.Large));

            BreakLoopUsingGoto();
        }
    }
}
