using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace multithread11
{
    class Program
    {
          
              public string Thread1()
            {
                for (int i = 1; i < 10; i++)
                {
                    if (i == 9)
                    {
                        Console.WriteLine("Thread1 is waiting for 5 seconds");
                        Thread.Sleep(5000);
                    }
                    Console.WriteLine("Thread1 is started at the position " + i);
                }
                return "Thread1 will stop";
            }


        //thread2
            public string Thread2()
            {
                for (int i = 1; i < 10; i++)
                {
                    if (i == 5)
                    {
                        Console.WriteLine("Thread2 is started at the position:" + i);
                       
                    }
                  
                }

            return ("the thread will stop");
            }

        //thread3
            public  string Thread3()
            {
                
            for(int j = 1; j < 10; j++)
            {
                Console.WriteLine("the thread3 is started at the position:" + j);
            }
            return "the thread3 stops";
            }

        //main method
            static void Main(string[] args)
            {
                Program obj = new Program();


                Thread T1 = new Thread(delegate ()
                {
                    Console.WriteLine(obj.Thread1());

                });
                T1.Start();

                Thread T2 = new Thread(delegate ()
                {
                    Console.WriteLine(obj.Thread2());

                });
                T2.Start();


            Thread T3 = new Thread(delegate ()
              {
                  Console.WriteLine(obj.Thread3());
              });
            T3.Start();


                Console.ReadKey();
            }

        }
    }
