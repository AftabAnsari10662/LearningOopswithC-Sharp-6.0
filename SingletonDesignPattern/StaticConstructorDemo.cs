using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public static class StaticConstructorDemo
    {

        // A Static constructor must be parameterless

        // Access modifiers are not allowed in static constructor

        //static StaticConstructorDemo(int size)
        //{

        //}

        static int x;
        static int y;
        static string name = "Aftab Ansari";
        static StaticConstructorDemo()
        {
            x = 36;
            y = 24;
            Console.WriteLine("static constructor executed.");
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public static void GetName(string name)
        {
            Console.WriteLine($"My name is {name}");

        }
    }
}
