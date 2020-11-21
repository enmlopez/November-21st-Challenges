using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenges
{
    public class Greeter
    {
        public string Greet(string name)
        {
            return "Hello " + name;
        }

        public string Bye(string name)
        {
            return "Later " + name;
        }

        //access modifer --return type -- [name(parameters) or method signature]
        public void GiveMeTimeOfDay(DateTime greeting)
        {
            int hour = greeting.Hour;
            if (hour >= 5 & hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour < 16)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (hour >= 16 && hour < 20)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");

            }

        }

        public void GivemeTimeofDay(int hour)
        {
           
            if (hour >= 5 & hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour >= 12 && hour < 16)
            {
                Console.WriteLine("Good afternoon!");
            }
            else if (hour >= 16 && hour < 20)
            {
                Console.WriteLine("Good evening!");
            }
            else
            {
                Console.WriteLine("Good night!");

            }
        }
    }
}
