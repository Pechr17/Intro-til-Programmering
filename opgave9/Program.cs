using System;
using System.Collections.Generic;
using test;

namespace opgave9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lav generisk liste med tre tal

            List<int> samling = new List<int>();
            samling.Add(5); samling.Add(3); samling.Add(9000);
            foreach(int element in samling)
            {
                Console.WriteLine(element);
            }

            //Løsning med Dictionary

            Dictionary<int, string> samling2 = new Dictionary<int, string>();
            samling2.Add(1, "halløj"); samling2.Add(9000, "hej"); samling2.Add(3, "Javel");

            Console.WriteLine(samling2[9000]);

            //Namespace test
            
            Console.WriteLine(t());
            Console.WriteLine("De næste to er ens, men den ene gør brug af namespace, og den anden gør ikke!: ");
            Console.WriteLine(test.N1.t());
            Console.WriteLine(N1.t());
            Console.WriteLine("Den sidste er et andet namespace, men funktionen hedder det samme: ");
            Console.WriteLine(test2.N1.t());

        }
        static int t()
        {
            return 1;
        }
    }
}

namespace test
{
    class N1
    {
        public static int t()
        {
            return 1;
        }
    }
}

namespace test2
{
    class N1
    {
        public static int t()
        {
            return 1;
        }
    }
 
}
