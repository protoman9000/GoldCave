using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoldCave
{
    class Program
    {
        public static void Swap(List<float> list, int a, int b)
        {
            float tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }

        static void setCombination(List<float> list, float bp)
        {
            double set = Math.Pow(2, list.Count);
            double set2 = 0;
            while (set2 < set - 1)
            {
                for (int x = 0; x < set; x++)
                {
                    int k = 0;
                    float carry = list[k] + list[k + 1];
                    k++;
                    while (carry < bp)
                    {
                        k++;
                        carry += list[k]; 
                    }
                    float tmp = carry;
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

           setCombination(goldList, gBackpack);

            //sort the list and put into a new list
            
            
            
            //List<List<float>> goldList2 = new List<List<float>>();

           

            Console.WriteLine("This is a test");

        }
    }
}
