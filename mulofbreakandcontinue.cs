using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class mulofbreakandcontinue
    {
        static void Main()
        {
            Console.WriteLine(" enter number : ");
            int i = int.Parse(Console.ReadLine());
            for(int j =1; j<= 15; j++)
            {
                Console.WriteLine($"{i}*{j} = {i * j}");
                if( j==6)
                {
                 
                    Console.WriteLine($"{i}*{j} = {i * j}");
                    continue;
                }
                if(j==8)
                {
                    
                    Console.WriteLine($"{i}*{j} = {i * j}");
                    break;
                }
            }
        }

    }
}
