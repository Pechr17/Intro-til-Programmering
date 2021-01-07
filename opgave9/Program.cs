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
        }
    }
}
