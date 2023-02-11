/* Name: Daniel Cunningham
 * Date: 2/10/2023
 * Description: TeddyBear class that extends the ToyBear interface and implements hug
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class TeddyBear : ToyBear
    {
        // Default constructor
        public TeddyBear() : base() { }

        // public void function that implements the hug signatures by printing "The teddy bear hugs."
        public void hug()
        {
            Console.WriteLine("The teddy bear hugs.");
        }
    }
}
