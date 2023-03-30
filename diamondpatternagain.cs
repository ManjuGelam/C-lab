using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class diamondpatternagain
    {
        static void Main()

        {
            Console.WriteLine(" enter number of rows :");
            int num = int.Parse(Console.ReadLine());
            int count = num - 1;
            for (int i = 1; i <= num + 1; i++) 
            {
                for (int j = 1; j <= count; j++)
                    Console.Write(" ");
                count--;
                for (int k = 1; k <= 2*i-1; k++)
                    Console.Write("*");
                Console.WriteLine();



                
            }
            count = 1;
            for(int i = 1; i<=num-1; i++)

            {
                for (int j = 1; j <= count; j++)
                    Console.Write(" " );
                        
                       
                     
                count++;
                for (int k = 1; k <= 2*(num - i)-1; k++)
                    Console.Write("*");
                Console.WriteLine();
                   
            }
            Console.ReadLine();
        }


    }
}
