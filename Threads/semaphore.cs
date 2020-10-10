using System;
using System.Threading;
using System.Threading.Tasks;

namespace semaphores
{
    class Program
    {
        public static Semaphore semaphore = new Semaphore(1, 3);
        
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread threadObject = new Thread(sync)
                {
                    Name = "Thread " + i
                };
                threadObject.Start(i);
            }
            Console.ReadKey();
        }

        static void sync(object id)
        {

            Console.WriteLine(Thread.CurrentThread.Name + "Enter into Critical Section for processing");
            try
            {
                //Blocks the current thread until the current WaitHandle receives a signal.   
                semaphore.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Doing its work");
                Thread.Sleep(10000);
                Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
            }
            finally
            {
                //Release() method to releage semaphore  
                semaphore.Release();
            }
        }

    }
}