﻿using DLLHell;
using System;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {

            Greeter _greeter = new Greeter();
            Console.WriteLine(_greeter.SayHello());
            Console.WriteLine(_greeter.SayGoodBye());

            Console.ReadLine();

        }
    }
}
