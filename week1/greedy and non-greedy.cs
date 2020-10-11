using System;
using System.Text.RegularExpressions;


namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "/pikachu/doreamon/";
            var result1 = Regex.Match(test, "^/.*?/");
            if(result1.Success)
                {
                Console.WriteLine("NON-GREDDY: {0}", result1.Success);

            }

            var result2 = Regex.Match(test, "^/.*/");
            if(result2.Success)
            {
                Console.WriteLine("GREEDY: {0}", result2.Success);
            }
            Console.ReadKey();
        }
    }
}