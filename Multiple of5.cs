using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace labprograms
{
    class Multiple_of5
    {
       
        static void Main()
        {
          
            IEnumerable<int> result = ((ParallelQuery<int>)ParallelEnumerable.Range( 3, 20)).Where(n => n % 5 == 0).Select(res => res);
            Console.WriteLine(" numbers are :");
            foreach(int numbers in result)
            {
                Console.WriteLine(numbers);
            }

        }
       
    }
}
