using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string input;
            int myNumber = 7;

            
            Console.WriteLine("Hello World.");
            Console.WriteLine(myNumber.ToString() + " This is our Original Number.");
            myNumber = myNumber + 2;
            Console.WriteLine(myNumber.ToString() + " This is our new Number.");
            input = Console.ReadLine();
            Console.WriteLine(input + "   ----This is our output----");
            Console.ReadLine();

            
            

        }
    }
}
