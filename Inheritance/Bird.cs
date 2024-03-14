using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{ 
    public class Bird : Animal
    {
        // Create a class Bird ---DONE
        // give this class 4 members that are specific to Bird   ---DONE
        // Set this class to inherit from your Animal Class   ---DONE
        public Bird() 
        {
        }
        public bool canFly { get; set; }
        public string beakSize { get; set; }
        public int wingSpan { get; set; }
        public bool itMigrates { get; set; }


    }
}
