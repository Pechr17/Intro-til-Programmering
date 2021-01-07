using System;

namespace Opgave7
{
    class Program
    {
        public int start_point = 50;
        static void Main(string[] args)
        {
            Program p = new Program();
            string func = Console.ReadLine();

            switch (func)
            {
                case "sin":
                    p.makeSin();
                    break;
                case "cos":
                    p.makeCos();
                    break;
                default:
                    Console.WriteLine("Wrong input.");
                    break;
            }
        }

        void makeSin()
        {
            int row = 1; int column = 0; double rad = 0;
            while(Console.ReadKey().Key != ConsoleKey.Q)
            {
                column = Convert.ToInt32(10 * Math.Sin(rad * Math.PI));
                 
                row++;

                rad += 0.2;
                Console.SetCursorPosition(column+start_point, row);
                Console.WriteLine("*");
            }
        }

        void makeCos()
        {
            int row = 1; int column = 0; double rad = 0;
            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                column = Convert.ToInt32(10 * Math.Cos(rad * Math.PI));
                row++;

                rad += 0.2;
                Console.SetCursorPosition(column + start_point, row);
                Console.WriteLine("*");
            }
        }
    }
}
