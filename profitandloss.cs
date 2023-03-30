using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class profitandloss
    {
        static Double Profit(double cp, double sp)
        {
            double Profit = (sp - cp);
            return Profit;
        }
        static double Loss(double cp, double sp)
        {
            double Loss = (cp - sp);
            return Loss;
        }
        public static void Main()
        {
            double cp = 2500, sp = 3000;
            Console.WriteLine("cp :" + cp);
            Console.WriteLine("sp :" + sp);
            if (sp == cp)
            {
                Console.WriteLine(" no loss no profit");
            }
            else if (sp < cp)
            {
                Console.WriteLine(" loss");
            }
            else
            {
                Console.WriteLine(" profit ");
            }



        }
    }
}