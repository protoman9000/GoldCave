using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoldCave
{
    class Program
    {
        public IEnumerable<IEnumerable<T>> combinationList<T>(List<T> list)
        {
            return from m in Enumerable.Range(0, 1 << list.Count)
                   select
                   from k in Enumerable.Range(0, list.Count)
                   where (m & (1 << k)) != 0
                   select list[k];
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
            var result = goldList.OrderByDescending(a => a);

            List<float> goldList2 = new List<float>();
            List<float> goldList3 = new List<float>();
            float finalGold = 0;

            foreach (var item in result)
            {
                goldList2.Add(item);
            }

            

            for (int i = 0; i < gPieces; i++)
            {
                finalGold += goldList2[i];
                if (finalGold > gBackpack)
                {
                    finalGold -= goldList2[i];
                    continue;
                }
                else
                {
                    goldList3.Add(goldList2[i]);
                }
            }

            //Output
            Console.WriteLine("");
            Console.WriteLine(finalGold);
            foreach (float k in goldList3)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("This is a test");

        }
    }
}
