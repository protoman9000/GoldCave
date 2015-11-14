using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoldCave
{
    class Program
    {
        public static void swap(List<float> list, int a, int b)
        {
            float tmp = list[a];
            list[a] = list[b];
            list[b] = tmp;
        }

        static float setCombination(List<float> list, float bp)
        {
            float tmp = 0;
            int place1 = 0;
            int place2 = 1;

            double set = Math.Pow(2, list.Count);
            double set2 = 0;
            while (set2 < set - 1)
            {
                for (int x = 0; x < set; x++)
                {
                    int k = 0;
                    float carry = list[k] + list[k + 1];
                    k++;
                    
                    while (carry < bp && k < list.Count)
                    {
                        k++;
                        carry += list[k]; 
                    }
                    
                    if(carry > tmp)
                        tmp = carry;
                    
                    
                    swap(list, place1, place2);
                    place1++;
                    place2++;

                    if (place1 < list.Count)
                        place1 = 0;
                    if (place2 > list.Count)
                        place2 = 1;                   
                }
            }
            return tmp;
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

            float answer = setCombination(goldList, gBackpack);

            Console.WriteLine(answer);


            
            
            //List<List<float>> goldList2 = new List<List<float>>();

           

            Console.WriteLine("This is a test");

        }
    }
}
