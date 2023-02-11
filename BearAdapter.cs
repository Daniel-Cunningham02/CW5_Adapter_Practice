using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class BearAdapter : ToyBear
    {
        private Bear adaptee;

        public BearAdapter(Bear bear) : base()
        {
            adaptee = bear;
        }

        public void hug()
        {
            Console.WriteLine("The bear hugs.");
            adaptee.maul();
        }
    }
}
