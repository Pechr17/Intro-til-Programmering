using System;
using System.Collections.Generic;

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
        }
    }
}

