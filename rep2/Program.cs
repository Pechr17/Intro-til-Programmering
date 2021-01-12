using System;
using System.Collections.Generic;

namespace rep2
{
    class Program
    {
        static void Main(string[] args)
        {
            typeUdregning action2;
            string con;
            char op = ' ';
            do
            {
                Console.WriteLine("Choose your numbers!");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose your method [add +, subtract -, divide /, multiply *]: ");
                string action = Console.ReadLine();

                //using enum
                if (Enum.TryParse(action, out action2))
                {
                    double res = Udregning(a, b, action2, ref op);
                    Console.WriteLine("{0} {1} {2} = {3}", a, op, b, res);
                }
                else
                {
                    Console.WriteLine("Wrong input type!");
                }

                Console.Write("Do you want to continue [y/n]: ");
                con = Console.ReadLine();
            } while (con == "yes" || con == "y");

            Console.WriteLine("Calculator is terminated.");
 
        }

      
        static float Udregning(int a, int b, typeUdregning op, ref char c)
        {
            float res;
            switch(op)
            {
                case typeUdregning.add:
                    res = a + b;
                    c = '+';
                    break;
                case typeUdregning.divide:
                    res = (float)a / b;
                    c = '/';
                    break;
                case typeUdregning.multiply:
                    res = a * b;
                    c = '*';
                    break;
                case typeUdregning.subtract:
                    res = a - b;
                    c = '-';
                    break;
                default:
                    Console.WriteLine("Something went wrong. Wrong input!");
                    return 0;
            }

            return res;
        }
       
    }
    enum typeUdregning
    {
        add,
        subtract,
        divide,
        multiply
    }
}
