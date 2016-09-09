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
            e1.NameChanged = new NameChangedDelegate(OnNameChanged);
            e1.Name = "Aftab";
            e1.Name = "Ansari";
            e1.Name = "Anshul";
            e1.Name = "Rohit";
        }

        private static void OnNameChanged(string oldValue, string newValue)
        {
            Console.WriteLine($"Name is changed from {oldValue} to {newValue}");
        }
    }
}
