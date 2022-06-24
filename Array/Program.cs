using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] scores = { 1, 4, 7, 5 };
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.Write(scores[i]);
            //}
            //foreach (int k in scores)
            //{
            //    Console.WriteLine(k);
            //}

            //Console.WriteLine("Hello World!");
            string[] Names = { "James", "John", "Micheal" };
            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine(Names[i]);
            }

            Console.WriteLine("Using foreach loop");

            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
