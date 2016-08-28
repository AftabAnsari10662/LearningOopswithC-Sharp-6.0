using System;

namespace SingletonDesignPattern
{

    public class Foo
    {
        private readonly int MAX;

        private Foo()
        {
            //A Readonly field can be initialzed only in constructor
            MAX = 200;
        }

        public int MAXIMUM
        {
            get
            {

                return MAX;
            }

            //set
            //{
            //    MAX = value;
            //}
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


            //Constant

            const int MAXIMUM = 100;
            const int MINIMUM = 10;
            //Not allowed
            //MAXIMUM = 200;
            //MINIMUM = 20;


            //Static Constructor Demo

            StaticConstructorDemo.GetName("Aftab Ansari");
            StaticConstructorDemo.GetName("Heena Firdous");

            Console.ReadLine();
        }
    }
}
