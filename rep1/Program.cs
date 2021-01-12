using System;

namespace rep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert two numbers to be added: ");
            int etNavn = Convert.ToInt32(Console.ReadLine()), etAndetNavn = Convert.ToInt32(Console.ReadLine());

            lægSammen(etNavn, etAndetNavn);
            Console.WriteLine(etNavn + " + " + etAndetNavn + " = " + lægSammen2(etNavn, etAndetNavn));
        }

        static void lægSammen(int a, int b)
        {
            int res = a + b;
            Console.WriteLine(res);
        }
        static int lægSammen2(int a, int b)
        {
            return a + b;
        }
    }
}
