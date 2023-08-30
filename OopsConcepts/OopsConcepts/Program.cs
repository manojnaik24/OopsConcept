using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class Program
  {
        //accessmodifier :accessmodifier a are keywords that can be used to controle the visiblety of field and method and constru in a class
        //public
        //private
        //internal
        //protected

        static void Main(string[] args)
        {
          PublicAM p= new PublicAM();
            p.PAM();
            Console.ReadLine(); 
        }
    }
}
