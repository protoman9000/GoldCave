using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoldCave
{
    class Program
    {
        private static void swap(ref float a, ref float b)
        {
            if (a == b)
                return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void getPer(float[] list)
        {
            int x = list.Length - 1;
            getPer(list, 0, x);
        }

        private static void getPer(float[] list, int k, int m)
        {
            if (k == m)
            {
                Console.Write(list);
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    swap(list[k], list[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            //Intro about the gold cave.
            Console.WriteLine("You are about to enter the golden cave...");
            Console.WriteLine("You are wearing a backpack. How much does your backpack weight?");
            
            //Convert the weight into float
            string backpack = Console.ReadLine();
            float gBackpack = float.Parse(backpack);

            //Checking to see how many gold nuggets there are
            Console.WriteLine("How many gold nuggets do you see?");
            string goldPieces = Console.ReadLine();
            int gPieces = Convert.ToInt16(goldPieces);

            //adding the gold pieces to the list. 
            List<float> goldList = new List<float>();

            for (int x = 1; x <= gPieces; x++)
            {
                Console.WriteLine("Enter the in gold piece number {0}", x);
                string piece = Console.ReadLine();
                float piece2 = float.Parse(piece);
                goldList.Add(piece2);
            }



            //sort the list and put into a new list
            
            
            
            List<List<float>> goldList2 = new List<List<float>>();

           

            Console.WriteLine("This is a test");

        }
    }
}
