using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LockThreads
{
    class Lockthreadsclass
    {

        public void Display()
        {
            lock (this)//is used to lock the other
            {
                Console.WriteLine("Csharp is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object oriented Programming Language");
            }
        }
        static void Main(string[] args)
        {

            Lockthreadsclass Object = new Lockthreadsclass();

            //object.Display();

            //Instantiated the thread with method Refrence
            Thread t1 = new Thread(Object.Display);

            Thread t2 = new Thread(Object.Display);
            Thread t3 = new Thread(Object.Display);
            Thread t4 = new Thread(Object.Display);
            t1.Start(); t2.Start(); t3.Start(); t4.Start();
            Co nsole.ReadKey();
        }
    } 
}