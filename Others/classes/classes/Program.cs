using System;

namespace classes
{
    internal class Program
    {
        public class Base
        {
            public virtual void Show()
            {
                Console.WriteLine("Shown from base class");
            }
        }
    
        public class myDerived : Base
        {
            //Override keyword does not change base class method
            public override void Show()
            {
                Console.WriteLine("Shown from derived class");
            }
        }
        
        public static void Main(string[] args)
        {
            Base objectReferenceToDerived = new myDerived();
            objectReferenceToDerived.Show();
        }
    }
}