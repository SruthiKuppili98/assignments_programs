using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgepatterns
{
    class BridgePatterns
    {

        class MainApp
        {
            static void Main()
            {
                Abstraction ab = new RefinedAbstraction();
                // Set implementation and call
                ab.Implementor = new ConcreteImplementorA();
                ab.Operation();
                // Change implemention and call
                ab.Implementor = new ConcreteImplementorB();
                ab.Operation();
                Console.ReadKey();
            }
        }
        class Abstraction//Abstract class
        {
            protected Implementor implementor;
            
            public Implementor Implementor
            {
                set { implementor = value; }
            }
            public virtual void Operation()
            {
                implementor.Operation();
            }
        }
        abstract class Implementor  // 'Implementor' abstract class
        {
            public abstract void Operation();
        }
        //'Refined ' abstract class
        class RefinedAbstraction : Abstraction
        {
            public override void Operation()
            {
                implementor.Operation();
            }
        }
        //'Concrete ImplementorA' class
        class ConcreteImplementorA : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorA Operation");
            }
        }
        //'ConcreteImplementorB' class
        class ConcreteImplementorB : Implementor
        {
            public override void Operation()
            {
                Console.WriteLine("ConcreteImplementorB Operation");
            }
        }
    }
}
    