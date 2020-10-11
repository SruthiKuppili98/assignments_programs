using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Join_threads
{
    class Program
    {
        public static void Thread1()
        {
            Console.WriteLine("Thread1 is starting");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Thread1 is Exiting!!!!" + i);
            }
            Console.WriteLine("Thread3 is Exited at run method");
        }
        static void Sync()
        {
            Console.WriteLine("4-2 results released");
            for (int i = 1; i < 15; i++)
            {
                Console.WriteLine("Happy to anounce" + i);
            }
            Console.WriteLine("I am Graduated");
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Demonstartion on Join Method in Multithreading");
            Console.WriteLine("Main Thread started");
            //Binded the method with the method object
            Thread T1 = new Thread(Thread1);
            T1.Start(); 
            T1.Join(); 
            Thread T2 = new Thread(Sync);
             T2.Start(); 
             T2.Join(); 

            Console.WriteLine("Main thread is exited");
            Console.ReadKey();

        }
    }
}