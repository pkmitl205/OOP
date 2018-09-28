using System;

namespace Inheritance
{
    // Inheritance 

    class Foo
    {
        public void WriteFoo()
        {
            Console.WriteLine("Foo");
        }
    }

    // Inherit from class Foo
    class Bar : Foo
    {
        public void WriteBar()
        {
            Console.WriteLine("Bar");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bar myBar = new Bar();
            myBar.WriteFoo(); // call method from class Foo (base class)
            myBar.WriteBar();
            Console.ReadLine();
        }
    }
}
