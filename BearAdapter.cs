/* Name: Daniel Cunningham
 * Date: 2/10/2023
 * Description: BearAdapter class that extends the ToyBear class and adaptes the Bear interface.
 */

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

        // Default Constructor that sets the private adaptee member to the bear parameter
        public BearAdapter(Bear bear) : base()
        {
            adaptee = bear;
        }
        // void function that prints "The bear hugs" and then uses the adaptee.maul member function
        public void hug()
        {
            Console.WriteLine("The bear hugs.");
            adaptee.maul();
        }
    }
}
