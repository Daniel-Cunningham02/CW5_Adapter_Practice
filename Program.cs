/* Name: Daniel Cunningham
 * Date: 2/10/2023
 * Description: Program class that run the main driver
 */


using System;


namespace CW5_Adapter_Practice {
    
    class Program
    {
        // Main driver
        static void Main(string[] args)
        {
            Grizzly bear1 = new Grizzly() ;
            TeddyBear bear2 = new TeddyBear();
            BearAdapter bear3 = new BearAdapter(bear1);

            bear1.maul();
            bear1.hibernate();
            Console.WriteLine();

            bear2.hug();
            Console.WriteLine();

            bear3.hug();

        }
    }

}

