using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System.IndexOutOfRangeException;

{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 12, 11, 2, 8, 6, 5, 7, 9, 4, 1 };
            int temp = 0;

            Console.WriteLine("elements in original array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                 for (int j = 1 +1; j < arr.Length; i++)
                {
                    if (arr[i] < arr[j]) 
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine();

		Console.WriteLine("elements of array sorted in ascending order:");
		for (int i = 0; i < arr.Length; i++)
	{
	    Console.WriteLine(arr[i] + " ");
            Console.ReadKey();
           }
       }
   }
}