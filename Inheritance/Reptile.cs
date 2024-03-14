using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // Create a class Reptile   DONE
        // give this class 4 members that are specific to Reptile   DONE
        // Set this class to inherit from your Animal Class   DONE
        public Reptile() 
        {
        }
        public bool changesColors {  get; set; }
        public bool isANopeRope { get; set; }
        public int lengthOfTale { get; set; }
        public bool hasScales { get; set; }

    }
}
