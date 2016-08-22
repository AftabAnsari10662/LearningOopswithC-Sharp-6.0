using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    public abstract class Employee
    {

        private string firstName = "Aftab";
        private string lastName = "Ansari";

        public void GetFullName()
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

    }

    public class PermanentEmployee : Employee
    {


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new PermanentEmployee();
            e.GetFullName();

            Console.ReadLine();
        }
    }
}
