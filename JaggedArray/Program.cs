using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 155, 145, 135, 170 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 4, 5, 6, 7, 7 };

            //alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 155, 145, 135, 170 },
                new int[] { 4, 5, 6, 7, 7 }
            };
            Console.WriteLine(jaggedArray2[0][1]);

            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element {0}", i);
                for(int j = 0; j <  jaggedArray2[i].Length; j++)
                {
                    Console.Write($"{jaggedArray2[i][j]} ");
                }
                Console.WriteLine();
            }

            //challenge
            string[][] friendsAndFamily = new string[][]
            {
                new string[] {"Michael", "Charles"},
                new string[] {"Tony", "Kamaru"},
                new string[] {"Israel", "Alex" }
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamily[1][1], friendsAndFamily[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamily[0][1], friendsAndFamily[2][1]);

            Console.ReadKey();
        }
    }
}
