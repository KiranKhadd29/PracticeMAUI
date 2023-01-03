using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PolyCar : Baseclass
    {
        public override void mahindraCar()
        {
            Console.WriteLine("Thar");
        }
    }
    class Polytruck : Baseclass
    {
        public override void mahindraCar()
        {
            Console.WriteLine("Choota Hatti");
        }
    }
   
}
