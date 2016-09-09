using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee e1 = new Employee();
            e1.NameChanged += new NameChangedDelegate(OnNameChanged);
            e1.NameChanged += new NameChangedDelegate(OnNameChanged2);
            e1.Name = "Aftab";
            e1.Name = "Ansari";
            e1.Name = "Anshul";
            e1.Name = "Rohit";

            //e1.NameChanged = null;
            //Not allowed if you use events

        }

        private static void OnNameChanged2(string oldValue, string newValue)
        {
            Console.WriteLine("Multicaste Delegates");
        }

        private static void OnNameChanged(string oldValue, string newValue)
        {
            Console.WriteLine($"Name is changed from {oldValue} to {newValue}");
        }
    }
}
