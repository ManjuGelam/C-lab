using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
   
        class NumberToWords
        {
            private static String[] units = { "Zero", "One", "Two", "Three",
    "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
    "Seventeen", "Eighteen", "Nineteen" };
            private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            public static String ConvertAmount(double amount)
            {


                Int64 amount_int = (Int64)amount;
                Int64 amount_dec = (Int64)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return Convert(amount_int) + " Only.";
                }
                else
                {
                    return Convert(amount_int) + " Point " + Convert(amount_dec) + " Only.";
                }



            }

            public static String Convert(Int64 i)
            {
                if (i < 20)
                {
                    return units[i];
                }
                if (i < 100)
                {
                    return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");
                }
                if (i < 1000)
                {
                    return units[i / 100] + " Hundred"
                            + ((i % 100 > 0) ? " And " + Convert(i % 100) : "");
                }

                return Convert(i / 10000) + " Arab "
                        + ((i % 10000 > 0) ? " " + Convert(i % 10000) : "");
            }
            static void Main(string[] args)
            {


                Console.WriteLine("Enter a Number to convert to words");
                string number = Console.ReadLine();
                number = ConvertAmount(double.Parse(number));

                Console.WriteLine("Number in words is \n{0}", number);
                Console.ReadKey();


            }
        }
    }


