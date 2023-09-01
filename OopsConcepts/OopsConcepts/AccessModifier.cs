using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public class AccessModifier
    {
        protected int Id = 10;
        public string Name = "Manoj Kumar Naik";
        internal double Number = 2.2;
        private int Rollno = 143;
        private protected int Roll = 24;
         public void AccessM()
        {
            Console.WriteLine(Rollno);
        }

        
        
    }
}
