﻿using System;
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

            Console.WriteLine("How many gold nuggets do you see?");
            string goldPieces = Console.ReadLine();
            int gPieces = Convert.ToInt16(goldPieces);

            List<double> goldList = new List<double>();

            for (int x = 1; x <= gPieces; x++)
            {
                int section = 0;
                Console.WriteLine("Enter the in gold piece number {0}", x);
                string piece = Console.ReadLine();
                goldList[section] = Convert.ToDouble(piece);
                section++;
            }

        }
    }
}
