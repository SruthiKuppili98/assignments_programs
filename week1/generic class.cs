using System;
using System.Reflection.PortableExecutable;

namespace ConsoleApp31
{

    class sleeping<T>
   {
	T bored;
   
    public sleeping(T sruthi)
   {
   
     this.bored = sruthi;
   
   }
 
 } 
    public void be_active()
    {
  
    Console.WriteLine("class is getting bored" + this.bored);
    }
}

    class example<T>  //Type Parameter <T>
    {
        T data; //type parameter declared

        //A method for Class Example
        public example(T check)
        {
            this.data = check;
        }

        public void Write()
        {

        Console.WriteLine("passes to the initializer:" + this.data);

    }
}

//Driver Mode/Main Method
    class Program
    {
        static void Main(string[] args)
        {
           

        //use the generic type exampe with an integer/string type parameter
        //instatiating the class example

        example<Int32> result = new example<int>(100);
        example<string> result1 = new example<string>("sruthi");
   

         sleeping<string> docker = new sleeping<stinr>("after lunch")
            
        //invoking the method Write() with object created result and result1
            result.Write();
            result1.Write();
            docker.be_active();

            Console.ReadKey();
    }
        
    }
}