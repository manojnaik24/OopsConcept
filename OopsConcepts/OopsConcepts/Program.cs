using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class Program:AccessModifier
    {
        //accessmodifier :accessmodifier a are keywords that can be used to controle the visiblety of field and method and constru in a class
        //public
        //private
        //internal
        //protected

        static void Main(string[] args)
        {

            //public AccessModifier allows a part of a program in same assembly (project)or an another
            //assembly to access the types and its member
           
            //Proctected AccessModifier allows code in the same class or a drived class to access its
            //its types and its member using inheritance
           
            //Internal AccessModifier Allows limited access only with in a file and the same assembly
           
            //private AccessModifier limited access only to the same class
            
            //Private Protected Accessmodifier: Access is granted to the containing class and its drived class present in the current assembly only.
            
            AccessModifier am = new AccessModifier();
            am.AccessM();
            Console.WriteLine(am.Name);
            Program p=new Program();
            Console.WriteLine(p.Id);
           // Console.WriteLine(am.number);
           // Console.WriteLine(p.roll);

           // Constctor ctor = new Constctor();
            Constctor ct = new Constctor("Manoj","23");
            Constctor age = new Constctor();


            Console.ReadLine();

        }
    }
}
