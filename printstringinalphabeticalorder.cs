using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class printstringinalphabeticalorder
    {
        static void Main(string[] args)
        {
            char temp;
            string myStr = "manju";  
            string str = myStr.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(charstr);   
            Console.ReadLine();
        }
    }
}  

    

