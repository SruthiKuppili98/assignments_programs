using System;
using System.Reflection;


namespace reflection
{

    class studentfunction
    {
        private string student;

        public void  student_class()
    
        {
            String name = "Jimin";
            int age = 25;
            Console.WriteLine(typeof(string));
          
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Type T = typeof(string);
            //intializing the T as typeofstring. (type ==> DataType)

            //use of reflections as below

            Console.WriteLine("Name:{0}", T.Name); //what type of method or type or feilds
            Console.WriteLine("FullName:{0}", T.FullName);  //what type of method or type or feilds
            Console.WriteLine("Namespace:{0}", T.Namespace);  //what type of method or type or feilds
            Console.WriteLine("BaseType:{0}", T.BaseType);  //what type of method or type or feilds

            int i = 42;
            System.Type type = i.GetType(); //System 32
            System.Console.WriteLine(type);
            Console.WriteLine(typeof(Type));
            

            //examples of use of refelection to obtain full name of the loaded assembly

            System.Reflection.Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info);


            Console.ReadKey();
        }
    }
}
