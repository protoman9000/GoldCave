using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoldCave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are about to enter the golden cave...");
            Console.WriteLine("You are wearing a backpack. How much does your backpack weight?");
            string backpack = Console.ReadLine();
            int gBackpack = Convert.ToInt16(backpack);
            decimal gBackpack2 = decimal.Round(7, gBackpack);

        }
    }
}
