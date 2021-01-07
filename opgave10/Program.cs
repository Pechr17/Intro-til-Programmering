using System;

namespace opgave10
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            værdi = 1;
            snyd = false;
        }

        public Terning(bool sn)
        {
            værdi = 1;
            snyd = sn;
        }
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

        
        }

        void Skriv()
        {
            Console.WriteLine("Du slog en {0}.", værdi);
        }
        int Ryst()
        {
            værdi = 0;
            if(!snyd)
            {
                værdi = rnd.Next(1, 7);
            }
            else
            {
                værdi = 6; //Lidt spøjst, men det siger opgaven
            }
           
            return værdi;
        }


        


    }
}
