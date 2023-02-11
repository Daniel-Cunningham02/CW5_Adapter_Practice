using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class Grizzly : Bear
    {
        public Grizzly() : base()
        {

        }
        public void maul()
        {
            Console.WriteLine("The bear mauls.");
        }

        public void hibernate()
        {
            Console.WriteLine("The bear hibernates.");
        }
    }
}
