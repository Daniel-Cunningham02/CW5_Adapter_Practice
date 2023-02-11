using System;


namespace CW5_Adapter_Practice {
    
    class Program
    {

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

