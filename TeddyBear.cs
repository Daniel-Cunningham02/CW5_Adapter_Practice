using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class TeddyBear : ToyBear
    {

        public TeddyBear() : base() { }
        public void hug()
        {
            Console.WriteLine("The teddy bear hugs.");
        }
    }
}
