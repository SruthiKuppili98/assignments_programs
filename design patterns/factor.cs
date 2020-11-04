using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgepatterns
{
    class factory
    {
        class FactoryDesignPattern
        {
            class MainApp
            {
                static void Main(string[] args)
                {
                    
                    Creator[] creators = new Creator[2];
                    creators[0] = new ConcreteCreatorA();
                    creators[1] = new ConcreteCreatorB();
                   
                    foreach (Creator obj in creators)
                    {
                        Product product = obj.FactoryMethod();
                        Console.WriteLine("Created {0}", product.GetType().Name);
                    }
                    ConcreteCreatorA cc1 = new ConcreteCreatorA();
                    cc1.Method1();
                    ConcreteCreatorB cc2 = new ConcreteCreatorB();
                    cc2.Method2();
                    Console.ReadKey();
                }
            }
            abstract class Product { }
            class ConcreteProductA : Product { }
            class ConcreteProductB : Product { }
            abstract class Creator
            {
                public abstract Product FactoryMethod();
            }
            class ConcreteCreatorA : Creator//A Concrete class
            {
                public override Product FactoryMethod()
                {
                    return new ConcreteProductA();
                }
                public void Method1()
                {
                    Console.WriteLine("This is ConcreteCreatorA class");
                }
            }
            class ConcreteCreatorB : Creator
            {
                public override Product FactoryMethod()
                {
                    return new ConcreteProductB();
                }
                public void Method2()
                {
                    Console.WriteLine("This is ConcreteCreatorB class");
                }
            }
        }
    }
}