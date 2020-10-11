using System;
using System.Text.RegularExpressions;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex example = new Regex(@"\A+");

            Match Match = example.Match("sruthi99sruthi");

            if (Match.Success)
            {
                Console.WriteLine("Match if specified character:" + Match.Value);
                Console.WriteLine("pattern matched");
            }

            //Output : art : art /B ==> start <middle> end
            string test = "aabb";


            //Match the start of a string
            if (Regex.IsMatch(test, "aa"))
            {

            
                Console.WriteLine("pattern matched ,where string is starting with");
            }
            Console.ReadKey();


        }


    
    }
}
