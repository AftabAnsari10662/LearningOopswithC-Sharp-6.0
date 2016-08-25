using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{

    class Program
    {
        static void Main(string[] args)
        {

            var text = "36.24";

            var parsedValue = text.ToDouble();
            Console.WriteLine($"value: {parsedValue}");
            Console.ReadLine();
        }
    }
}
