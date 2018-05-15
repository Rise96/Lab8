using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<List<int>>();
            var row = new List<int>();
            var rand = new Random();
            int n = rand.Next(3, 6);

            for (int i = 0; i < n; i++)
            {
                row = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    row.Add(rand.Next(-30, 30));
                }

                array.Add(row);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i][j].ToString() + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            var inserter = new Inserter();
            List<List<int>> array2 = inserter.Insert(array);

            for (int i = 0; i <array2.Count; i++)
            {
                for (int j = 0; j < array2[i].Count; j++)
                {
                    Console.Write(array2[i][j].ToString() + " ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
