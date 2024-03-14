using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        // Create a class Animal --DONE
        // give this class 4 members that all Animals have in common ---DONE
        public Animal() 
        {
        }
        public int Legs { get; set; }
        public int Age { get; set; }
        public bool IsExtinct { get; set; }

        public string Diet { get; set; }
    }
}
