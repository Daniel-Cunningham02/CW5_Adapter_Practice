/* Name: Daniel Cunningham
 * Date: 2/10/2023
 * Description: Grizzly class that extends the Bear interface. It also implements the maul and hibernate signatures
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5_Adapter_Practice
{
    internal class Grizzly : Bear
    {
        // Default Constructor
        public Grizzly() : base()
        {

        }

        // public void function that implements the signature maul and prints "The bear mauls."
        public void maul()
        {
            Console.WriteLine("The bear mauls.");
        }

        // public void function that implements the signature hibernate and prints "The bear hibernates."
        public void hibernate()
        {
            Console.WriteLine("The bear hibernates.");
        }
    }
}
