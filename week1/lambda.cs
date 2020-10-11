using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class lambdaexpression
    {
        public delegate void Addnums2Delegate(int x, float y, double z);
        public delegate void GreetingsDelegate(string str);
        static void Main(string[] Args)
        {
            

            List<int> numbers = new List<int>() {01,04,09,12,13,18,30 };
            Console.WriteLine("The elements of List are:");
           
            var sum = numbers.Select(z => z + z + z);
            foreach (var num in numbers)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();
            

            Addnums2Delegate obj1 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj1.Invoke(13, 3.142f, 123456.123456789);

            GreetingsDelegate w = (wish) =>
            {
                Console.WriteLine(wish + "  " + "Happy Birthday Jimin!!!!!!");
            };
            Console.ReadKey();
           
            var qube = numbers.Select(y => y * y * y);

            foreach (var number in qube)
            {
                Console.WriteLine("{0}", number);
            }
            Console.ReadKey();



        }
    }
}
