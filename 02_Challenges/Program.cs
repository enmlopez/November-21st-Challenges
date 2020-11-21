using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            string person = greeter.Greet("Joshua\n");
            Console.WriteLine(person);

            string person2 = greeter.Bye("Johua\n");
            Console.WriteLine(person2);

            DateTime greeting = DateTime.Now;
            greeter.GiveMeTimeOfDay(greeting);

            DateTime newGreeting = new DateTime(2020, 10, 31, 5, 20, 3);
            greeter.GiveMeTimeOfDay(newGreeting);

            greeter.GivemeTimeofDay(17);

            Console.WriteLine("**************");

            Console.ReadKey();




        }
    }
}

