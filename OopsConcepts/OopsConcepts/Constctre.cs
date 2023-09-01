using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Constctor
    {
        //constrcutre is spacila method of a class that is automaticaly invoked when in instacnd of a class is created 
        //constrcuter is same name has the class name it don't have return type 

        //defult Constructor which not parimeters

        string name;
        string age;

        public Constctor(string name, string ages)
        {


            this.name = name;
            Console.WriteLine(this.name);
              age = ages;
        }
        public Constctor()
        {


            Console.WriteLine("first Constructor");
            Console.WriteLine("first Constructor");
            Console.WriteLine("first Constructor");
            Console.WriteLine("first Constructor");
            Console.WriteLine("first Constructor");
            Console.WriteLine("first Constructor");

        }

        
    }
}