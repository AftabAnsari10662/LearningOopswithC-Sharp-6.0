using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingVsMethodOverriding
{
    public class Employee
    {

        public void GetFullName()
        {
            Console.WriteLine("I am a base class method.");
        }
    }

    public class PermanentEmployee:Employee
    {

        public new void GetFullName()
        {
            Console.WriteLine("I am a child class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee e = new PermanentEmployee();

            e.GetFullName();
        }
    }
}
