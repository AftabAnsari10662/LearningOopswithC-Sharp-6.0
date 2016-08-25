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

    public class PermanentEmployee : Employee
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

            //Employee e = new PermanentEmployee();

            // e.GetFullName();

            IEnumerable<Friend> friends = new Friend[]
                                         {

                                             new Friend() {
                                             Id = 1,
                                             FirstName ="Aftab",
                                             LastName = "Ansari",
                                             EmailId = "aftabansari10662@gmail.com",
                                             twitterUrl ="https://twitter.com/AftabAnsari1066"
                                           },
                                             new Friend() {
                                             Id = 2,
                                             FirstName ="Anshul",
                                             LastName = "Rana",
                                             EmailId = "anshul.rana@gmail.com",
                                             twitterUrl =""
                                           },
                                             new Friend() {
                                             Id = 3,
                                             FirstName ="Chaithra",
                                             LastName = "Mandanna",
                                             EmailId = "chai.m@gmail.com",
                                             twitterUrl =""
                                           },
                                             new Friend() {
                                             Id = 4,
                                             FirstName ="Rohit",
                                             LastName = "Kumar",
                                             EmailId = "rohit.kumar@gmail.com",
                                             twitterUrl =""
                                           }
                                         };


            IEnumerator<Friend> enumerators = friends.GetEnumerator();

            while (enumerators.MoveNext())
            {

                Console.WriteLine(enumerators.Current.FirstName);
            }


            foreach (var friend in friends)
            {
                Console.WriteLine($"First Name:{friend.FirstName}");
            }
            Console.ReadLine();
        }
    }
}
