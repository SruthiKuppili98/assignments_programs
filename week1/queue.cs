using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>();
            q1.Enqueue(10);
            q1.Enqueue(13);
            q1.Enqueue(07);

            
            foreach(var x in q1)
            {
                Console.WriteLine("elements present in queue are:" + x);
            }
            
            Console.WriteLine("first element in queue is:" + q1.Peek());
            
            Console.WriteLine("deleted element is:" + q1.Dequeue());
            
	    foreach (var x in q1)
            
	   {
                Console.WriteLine("elements in queue after deleting are:" + x);
           
	   }
            
            Console.WriteLine("elements present in queue is :" + q1.Count());

            Console.ReadKey();
        }
    }
}
