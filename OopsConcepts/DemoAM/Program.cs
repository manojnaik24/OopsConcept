using OopsConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAM
{
    internal class Program : AccessModifier
    {
        static void Main(string[] args)
        {
            AccessModifier ee = new AccessModifier();
            Program program = new Program();
            Console.WriteLine(program.Id);
            Console.WriteLine(ee.Name);
            //Console.WriteLine(ee.Number);
           // Console.WriteLine(ee.Rollno);
           // Console.WriteLine(ee.Roll);


        }
    }
}
