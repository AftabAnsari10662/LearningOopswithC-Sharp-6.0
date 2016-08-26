using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{

    public class Foo
    {
        private Foo()
        {

        }

        public int X { get; set; }
        private static Foo FooInstance { get; set; }

        public static Foo GetInstance()
        {
            if (FooInstance == null)
            {
                FooInstance = new Foo();
            }

            return FooInstance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var foo1 = Foo.GetInstance();
            foo1.X = 20;
            var foo2 = Foo.GetInstance();

            Console.WriteLine(foo1.X);
            Console.WriteLine(foo2.X);
            Console.ReadLine();
        }
    }
}
