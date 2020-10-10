using System;
using System.Threading;
namespace MutexDemo
{
    class Program
    {   
        private static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            //Create multiple threads
 
            for (int i = 1; i <= 10; i++)
            {
                Thread threadObject = new Thread(MutexDemo);
                threadObject.Name = "Thread " + i;
                threadObject.Start();
            }
            Console.ReadKey();
        }
        //implement syncronization using Mutex 
 
        static void MutexDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "Enter Critical Section for processing");
            try
            {
              //Blocks the current thread until the current WaitOne method receives a signal.  
                mutex.WaitOne();  
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
                Thread.Sleep(2000);
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");
            }
            finally
            {
                //Call the ReleaseMutex method to unblock so that other threads
                
                mutex.ReleaseMutex();
            }
        }
    }
}