using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 45, 67, 93, 8, 61, 74, 52, 82, 97, 27, 49, 58, 79, 86, 14, 3, 23, 37, 92 };

            var brr = from i in arr where i > 40 orderly i descending select i;
            var brr = from i in arr where i > 20 orderly i ascending select i;

            foreach(int x in brr)
            {
                Console.WriteLine("elemnts of the array are:" + x + " ");
                Console.ReadLine();
            }
        }
    }
}