using System;
using System.Reflection;
using System.Data;

namespace CSharpGenericConstraints
{  
    //we have created a generic class with the type parameter and assigned the constarint Exception
    class Ruby<T> where T :IDisposable
        {
        public void test1()
        {
            Console.WriteLine("example of constraints");
        }
    }

    ////we have created a generic class with the type parameter and assigned the constarint struct
    class C <T> where T : struct
    {
        public void test2()
        {
            Console.WriteLine("example on struct");
        }

    }
    //refernce type with constructor

        class read <V> where V : class, new()
    {
        public void test3()
        {
            Console.WriteLine("example on class");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Ruby<DataTable> ruby = new Ruby<DataTable>();
            //to store the data with class ruby
            C<int> java = new C<int>();
            read<Program> test = new read<Program>();
            ruby.test1();
            java.test2();
            test.test3();
            Console.ReadKey();

        }
    }
}
