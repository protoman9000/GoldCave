using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


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
            int count = 0;
            while (count != set)
            {
                int k = 0;
                float carry = list[k];
                k++;

                while (carry < bp && k < list.Count)
                {
                    if (carry < bp)
                    {
                        if (carry > tmp)
                        {
                            tmp = carry;
                        }
                    }
                    carry += list[k];
                    k++;
                }

                swap(list, place1, place2);
                place1++;
                place2++;

                if (place1 >= list.Count)
                    place1 = 0;
                if (place2 >= list.Count)
                    place2 = 1;

                carry = 0;
                count++;
            }
            return tmp;
        }


        static void Main(string[] args)
        {
            //Setting up a timer.
            Stopwatch timer = new Stopwatch();
            timer.Start();
            
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\Users\\Aziz\\Downloads\\TestWord.txt");

            //Intro about the gold cave.
            Console.WriteLine("You are about to enter the golden cave...");
            Console.ReadKey();

            string backpack = file.ReadLine();
            Console.WriteLine("You are wearing a backpack. It weights around {0}" , backpack);
            Console.ReadKey();

            //Convert the weight into float
            float gBackpack = float.Parse(backpack);

            //Checking to see how many gold nuggets there are            
            string goldPieces = file.ReadLine();
            Console.WriteLine("There are {0} gold nuggets.", goldPieces);
            Console.ReadKey();
            int gPieces = Convert.ToInt16(goldPieces);

            //adding the gold pieces to the list. 
            List<float> goldList = new List<float>();

            for (int x = 1; x <= gPieces; x++)
            {
                string piece = file.ReadLine();
                float piece2 = float.Parse(piece);
                goldList.Add(piece2);
            }

            float answer = setCombination(goldList, gBackpack);

            Console.WriteLine(answer);
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            Console.ReadKey();

        }

    }
}