using System;
using System.Collections.Generic;

namespace CSharpDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();
            MyDictionary.Add(1, "ONE");
            MyDictionary.Add(3, "THREE");
            MyDictionary.Add(7, "SEVEN");

            foreach (KeyValuePair<int, string> check in MyDictionary)

            {
                Console.WriteLine("Elements of MyDictionary are:" + check.Key + " " + check.Value);
            }
            Console.WriteLine("Number of elements present in the MyDictionary:" + MyDictionary.Count());

            //get a dictionary item using set and get procedure

            //set the item value

            MyDictionary[3] = "TWO";
            MyDictionary[4] = "FIVE";
            MyDictionary[5] = "FOUR";
            MyDictionary[6] = "SIX";

            Console.WriteLine("Elements of MyDictionary are:" + check.Key + " " + check.Value);
	    Console.WriteLine("Elements left in MyDictionary after removed:" + MyDictionary.Remove("THREE"));
           
            Console.ReadKey();

        }
    }
}
